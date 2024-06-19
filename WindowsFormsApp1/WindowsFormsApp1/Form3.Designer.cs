namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lbVerMascotas = new System.Windows.Forms.ListBox();
            this.lbVerMascotasOrdenadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbVerMascotas
            // 
            this.lbVerMascotas.FormattingEnabled = true;
            this.lbVerMascotas.Location = new System.Drawing.Point(12, 12);
            this.lbVerMascotas.Name = "lbVerMascotas";
            this.lbVerMascotas.Size = new System.Drawing.Size(298, 82);
            this.lbVerMascotas.TabIndex = 0;
            // 
            // lbVerMascotasOrdenadas
            // 
            this.lbVerMascotasOrdenadas.FormattingEnabled = true;
            this.lbVerMascotasOrdenadas.Location = new System.Drawing.Point(12, 100);
            this.lbVerMascotasOrdenadas.Name = "lbVerMascotasOrdenadas";
            this.lbVerMascotasOrdenadas.Size = new System.Drawing.Size(298, 95);
            this.lbVerMascotasOrdenadas.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.lbVerMascotasOrdenadas);
            this.Controls.Add(this.lbVerMascotas);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbVerMascotas;
        public System.Windows.Forms.ListBox lbVerMascotasOrdenadas;
    }
}