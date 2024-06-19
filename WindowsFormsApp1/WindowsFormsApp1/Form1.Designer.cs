namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.btnVerListaOrdenada = new System.Windows.Forms.Button();
            this.btnBuscarPerro = new System.Windows.Forms.Button();
            this.tbBuscarEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarMascota.TabIndex = 0;
            this.btnAgregarMascota.Text = "Agregar Mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // btnVerLista
            // 
            this.btnVerLista.Location = new System.Drawing.Point(12, 41);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(147, 23);
            this.btnVerLista.TabIndex = 1;
            this.btnVerLista.Text = "Ver Lista de Mascotas";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnVerListaOrdenada
            // 
            this.btnVerListaOrdenada.Location = new System.Drawing.Point(13, 70);
            this.btnVerListaOrdenada.Name = "btnVerListaOrdenada";
            this.btnVerListaOrdenada.Size = new System.Drawing.Size(147, 23);
            this.btnVerListaOrdenada.TabIndex = 2;
            this.btnVerListaOrdenada.Text = "Ver lista ordenada";
            this.btnVerListaOrdenada.UseVisualStyleBackColor = true;
            this.btnVerListaOrdenada.Click += new System.EventHandler(this.btnVerListaOrdenada_Click);
            // 
            // btnBuscarPerro
            // 
            this.btnBuscarPerro.Location = new System.Drawing.Point(13, 99);
            this.btnBuscarPerro.Name = "btnBuscarPerro";
            this.btnBuscarPerro.Size = new System.Drawing.Size(147, 23);
            this.btnBuscarPerro.TabIndex = 3;
            this.btnBuscarPerro.Text = "Buscar perro por edad";
            this.btnBuscarPerro.UseVisualStyleBackColor = true;
            this.btnBuscarPerro.Click += new System.EventHandler(this.btnBuscarPerro_Click);
            // 
            // tbBuscarEdad
            // 
            this.tbBuscarEdad.Location = new System.Drawing.Point(35, 128);
            this.tbBuscarEdad.Name = "tbBuscarEdad";
            this.tbBuscarEdad.Size = new System.Drawing.Size(100, 20);
            this.tbBuscarEdad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 154);
            this.Controls.Add(this.tbBuscarEdad);
            this.Controls.Add(this.btnBuscarPerro);
            this.Controls.Add(this.btnVerListaOrdenada);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.btnAgregarMascota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Button btnVerListaOrdenada;
        private System.Windows.Forms.Button btnBuscarPerro;
        private System.Windows.Forms.TextBox tbBuscarEdad;
    }
}

