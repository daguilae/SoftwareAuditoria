namespace SoftwareDeAuditoria
{
    partial class Reportes
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
            this.gestionReportes1 = new RCapaVista.GestionReportes();
            this.SuspendLayout();
            // 
            // gestionReportes1
            // 
            this.gestionReportes1.Location = new System.Drawing.Point(11, 11);
            this.gestionReportes1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gestionReportes1.Name = "gestionReportes1";
            this.gestionReportes1.Size = new System.Drawing.Size(959, 433);
            this.gestionReportes1.TabIndex = 0;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 433);
            this.Controls.Add(this.gestionReportes1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private RCapaVista.GestionReportes gestionReportes1;
    }
}