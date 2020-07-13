﻿namespace UI.Desktop
{
    partial class MateriaDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.idmateria = new System.Windows.Forms.Label();
            this.hstotales = new System.Windows.Forms.Label();
            this.idplan = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.hssemanales = new System.Windows.Forms.Label();
            this.txtIdmateria = new System.Windows.Forms.TextBox();
            this.txtHssemanales = new System.Windows.Forms.TextBox();
            this.txtIdplan = new System.Windows.Forms.TextBox();
            this.txtHstotales = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.idmateria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hstotales, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.idplan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.descripcion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.hssemanales, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIdmateria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtHssemanales, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIdplan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHstotales, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(203, 93);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // idmateria
            // 
            this.idmateria.AutoSize = true;
            this.idmateria.Location = new System.Drawing.Point(3, 0);
            this.idmateria.Name = "idmateria";
            this.idmateria.Size = new System.Drawing.Size(56, 13);
            this.idmateria.TabIndex = 2;
            this.idmateria.Text = "ID Materia";
            // 
            // hstotales
            // 
            this.hstotales.AutoSize = true;
            this.hstotales.Location = new System.Drawing.Point(203, 30);
            this.hstotales.Name = "hstotales";
            this.hstotales.Size = new System.Drawing.Size(72, 13);
            this.hstotales.TabIndex = 6;
            this.hstotales.Text = "Horas totales ";
            // 
            // idplan
            // 
            this.idplan.AutoSize = true;
            this.idplan.Location = new System.Drawing.Point(3, 30);
            this.idplan.Name = "idplan";
            this.idplan.Size = new System.Drawing.Size(42, 13);
            this.idplan.TabIndex = 3;
            this.idplan.Text = "ID Plan";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(3, 60);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 4;
            this.descripcion.Text = "Descripcion";
            // 
            // hssemanales
            // 
            this.hssemanales.AutoSize = true;
            this.hssemanales.Location = new System.Drawing.Point(203, 0);
            this.hssemanales.Name = "hssemanales";
            this.hssemanales.Size = new System.Drawing.Size(88, 13);
            this.hssemanales.TabIndex = 5;
            this.hssemanales.Text = "Horas semanales";
            // 
            // txtIdmateria
            // 
            this.txtIdmateria.Location = new System.Drawing.Point(103, 3);
            this.txtIdmateria.Name = "txtIdmateria";
            this.txtIdmateria.ReadOnly = true;
            this.txtIdmateria.Size = new System.Drawing.Size(94, 20);
            this.txtIdmateria.TabIndex = 7;
            // 
            // txtHssemanales
            // 
            this.txtHssemanales.Location = new System.Drawing.Point(303, 3);
            this.txtHssemanales.Name = "txtHssemanales";
            this.txtHssemanales.Size = new System.Drawing.Size(100, 20);
            this.txtHssemanales.TabIndex = 8;
            // 
            // txtIdplan
            // 
            this.txtIdplan.Location = new System.Drawing.Point(103, 33);
            this.txtIdplan.Name = "txtIdplan";
            this.txtIdplan.ReadOnly = true;
            this.txtIdplan.Size = new System.Drawing.Size(94, 20);
            this.txtIdplan.TabIndex = 9;
            // 
            // txtHstotales
            // 
            this.txtHstotales.Location = new System.Drawing.Point(303, 33);
            this.txtHstotales.Name = "txtHstotales";
            this.txtHstotales.Size = new System.Drawing.Size(100, 20);
            this.txtHstotales.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 63);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(94, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MateriaDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 120);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label idmateria;
        private System.Windows.Forms.Label hstotales;
        private System.Windows.Forms.Label idplan;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label hssemanales;
        private System.Windows.Forms.TextBox txtIdmateria;
        private System.Windows.Forms.TextBox txtHssemanales;
        private System.Windows.Forms.TextBox txtIdplan;
        private System.Windows.Forms.TextBox txtHstotales;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}