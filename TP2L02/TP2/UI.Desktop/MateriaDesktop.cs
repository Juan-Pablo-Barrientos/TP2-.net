﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Util.entities;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public Materia MateriaActual;
        List<Plan> Planes = new PlanLogic().GetAll();    
        #region constructores
        public MateriaDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;                        
            foreach (var p in Planes)
            {           
              cBIdPlan.Items.Add(p.Descripcion);           
            }
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;          
            MateriaActual = new MateriaLogic().getOne(ID);           
            MapearDeDatos();
        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtIdmateria.Text = this.MateriaActual.ID.ToString();                  
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHssemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHstotales.Text = this.MateriaActual.HSTotales.ToString();
            foreach (var p in Planes .Where(p => p.ID == MateriaActual.IDPlan))
            {
                this.cBIdPlan.Text = p.Descripcion;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

        }
      public override void MapearADatos()
        {

            if (Modo == ModoForm.Alta)
            {
                MateriaActual = new Materia();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {              
                MateriaActual.Descripcion = txtDescripcion.Text;                           
                MateriaActual.HSSemanales = Convert.ToInt32(txtHssemanales.Text);
                MateriaActual.HSTotales = Convert.ToInt32(txtHstotales.Text);
                foreach (var p in Planes.Where(p => p.Descripcion == cBIdPlan.Text))
                {
                    MateriaActual.IDPlan = p.ID;
                }

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            MateriaActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            MateriaActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            MateriaActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            MateriaActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {  
            MapearADatos();       
            new MateriaLogic().Save(MateriaActual);
        }
        public override bool Validar()
        {
            var validador = new Validador();
            List<string> Campos = (this.container.Controls.OfType<TextBox>().Where(txt => txt.ReadOnly == false).Select(txt => txt.Text)).ToList();
            if (!BusinessLogic.SonCamposValidos(Campos)) validador.AgregarError("No todos los campos estan completos");
            if (cBIdPlan.SelectedItem == null) validador.AgregarError("Elija una especialidad");
            if (!validador.EsValido()) BusinessLogic.Notificar("Materia",validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
            return validador.EsValido();
        }

   

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();

                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            
        }

        //Este metodo esta linkeado con el evento KeyPress, no permite que se ingrese otro caracter que no sea numerico
        //Lo TextBox para la hora lo usan.
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;                          
        }     
    }
}
