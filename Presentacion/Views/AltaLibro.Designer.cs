namespace Presentacion.Views
{
    partial class AltaLibro
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblCategoriaLibro = new System.Windows.Forms.Label();
            this.lblEstadoLibro = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbCategoriaLibro = new System.Windows.Forms.ComboBox();
            this.cmbEstadoLibro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(17, 30);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(44, 13);
            this.lblNombreLibro.TabIndex = 1;
            this.lblNombreLibro.Text = "Nombre";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Location = new System.Drawing.Point(17, 71);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(32, 13);
            this.lblAutorLibro.TabIndex = 3;
            this.lblAutorLibro.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(101, 64);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(215, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // lblCategoriaLibro
            // 
            this.lblCategoriaLibro.AutoSize = true;
            this.lblCategoriaLibro.Location = new System.Drawing.Point(17, 110);
            this.lblCategoriaLibro.Name = "lblCategoriaLibro";
            this.lblCategoriaLibro.Size = new System.Drawing.Size(54, 13);
            this.lblCategoriaLibro.TabIndex = 5;
            this.lblCategoriaLibro.Text = "Categoría";
            // 
            // lblEstadoLibro
            // 
            this.lblEstadoLibro.AutoSize = true;
            this.lblEstadoLibro.Location = new System.Drawing.Point(17, 153);
            this.lblEstadoLibro.Name = "lblEstadoLibro";
            this.lblEstadoLibro.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoLibro.TabIndex = 7;
            this.lblEstadoLibro.Text = "Estado";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(101, 188);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(182, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbCategoriaLibro
            // 
            this.cmbCategoriaLibro.FormattingEnabled = true;
            this.cmbCategoriaLibro.Location = new System.Drawing.Point(101, 102);
            this.cmbCategoriaLibro.Name = "cmbCategoriaLibro";
            this.cmbCategoriaLibro.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaLibro.TabIndex = 10;
            // 
            // cmbEstadoLibro
            // 
            this.cmbEstadoLibro.FormattingEnabled = true;
            this.cmbEstadoLibro.Location = new System.Drawing.Point(101, 145);
            this.cmbEstadoLibro.Name = "cmbEstadoLibro";
            this.cmbEstadoLibro.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoLibro.TabIndex = 11;
            // 
            // AltaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 240);
            this.Controls.Add(this.cmbEstadoLibro);
            this.Controls.Add(this.cmbCategoriaLibro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEstadoLibro);
            this.Controls.Add(this.lblCategoriaLibro);
            this.Controls.Add(this.lblAutorLibro);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.txtNombre);
            this.Name = "AltaLibro";
            this.Text = "Alta y Modificación Libros";
            this.Load += new System.EventHandler(this.AltaLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblCategoriaLibro;
        private System.Windows.Forms.Label lblEstadoLibro;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbCategoriaLibro;
        private System.Windows.Forms.ComboBox cmbEstadoLibro;
    }
}