namespace Presentacion
{
    partial class Form1
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
            this.btnPruebaConexion = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnModificacionLibro = new System.Windows.Forms.Button();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultaLibros = new System.Windows.Forms.Button();
            this.btnConsultaLibrosUnidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPruebaConexion
            // 
            this.btnPruebaConexion.Location = new System.Drawing.Point(12, 12);
            this.btnPruebaConexion.Name = "btnPruebaConexion";
            this.btnPruebaConexion.Size = new System.Drawing.Size(145, 43);
            this.btnPruebaConexion.TabIndex = 0;
            this.btnPruebaConexion.Text = "Prueba de conexión";
            this.btnPruebaConexion.UseVisualStyleBackColor = true;
            this.btnPruebaConexion.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(185, 27);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(314, 61);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(145, 43);
            this.btnEliminarLibro.TabIndex = 2;
            this.btnEliminarLibro.Text = "Eliminar Libro";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnModificacionLibro
            // 
            this.btnModificacionLibro.Location = new System.Drawing.Point(163, 61);
            this.btnModificacionLibro.Name = "btnModificacionLibro";
            this.btnModificacionLibro.Size = new System.Drawing.Size(145, 43);
            this.btnModificacionLibro.TabIndex = 3;
            this.btnModificacionLibro.Text = "Modificación Libro";
            this.btnModificacionLibro.UseVisualStyleBackColor = true;
            this.btnModificacionLibro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(12, 61);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(145, 43);
            this.btnAltaLibro.TabIndex = 4;
            this.btnAltaLibro.Text = "Alta Libro";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 284);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnConsultaLibros
            // 
            this.btnConsultaLibros.Location = new System.Drawing.Point(12, 110);
            this.btnConsultaLibros.Name = "btnConsultaLibros";
            this.btnConsultaLibros.Size = new System.Drawing.Size(145, 43);
            this.btnConsultaLibros.TabIndex = 6;
            this.btnConsultaLibros.Text = "Consulta Libros";
            this.btnConsultaLibros.UseVisualStyleBackColor = true;
            // 
            // btnConsultaLibrosUnidades
            // 
            this.btnConsultaLibrosUnidades.Location = new System.Drawing.Point(163, 110);
            this.btnConsultaLibrosUnidades.Name = "btnConsultaLibrosUnidades";
            this.btnConsultaLibrosUnidades.Size = new System.Drawing.Size(145, 43);
            this.btnConsultaLibrosUnidades.TabIndex = 7;
            this.btnConsultaLibrosUnidades.Text = "Consulta Libros Unidades";
            this.btnConsultaLibrosUnidades.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 470);
            this.Controls.Add(this.btnConsultaLibrosUnidades);
            this.Controls.Add(this.btnConsultaLibros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAltaLibro);
            this.Controls.Add(this.btnModificacionLibro);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPruebaConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaConexion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnModificacionLibro;
        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultaLibros;
        private System.Windows.Forms.Button btnConsultaLibrosUnidades;
    }
}

