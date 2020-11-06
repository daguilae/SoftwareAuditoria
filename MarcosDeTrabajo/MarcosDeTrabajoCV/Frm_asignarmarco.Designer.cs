namespace MarcosDeTrabajoCV
{
    partial class Frm_asignarmarco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_asignarmarco));
            this.Nav_marcosdetrabajo = new CapaDeDiseno.Navegador();
            this.Pnl_marcosdetrabajo = new System.Windows.Forms.Panel();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_marcosdetrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nav_marcosdetrabajo
            // 
            this.Nav_marcosdetrabajo.BackColor = System.Drawing.Color.White;
            this.Nav_marcosdetrabajo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nav_marcosdetrabajo.Location = new System.Drawing.Point(-2, 28);
            this.Nav_marcosdetrabajo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nav_marcosdetrabajo.Name = "Nav_marcosdetrabajo";
            this.Nav_marcosdetrabajo.Size = new System.Drawing.Size(841, 644);
            this.Nav_marcosdetrabajo.TabIndex = 0;
            this.Nav_marcosdetrabajo.Load += new System.EventHandler(this.Nav_marcosdetrabajo_Load);
            // 
            // Pnl_marcosdetrabajo
            // 
            this.Pnl_marcosdetrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Pnl_marcosdetrabajo.Controls.Add(this.pictureBox1);
            this.Pnl_marcosdetrabajo.Controls.Add(this.Lbl_titulo);
            this.Pnl_marcosdetrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_marcosdetrabajo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_marcosdetrabajo.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_marcosdetrabajo.Name = "Pnl_marcosdetrabajo";
            this.Pnl_marcosdetrabajo.Size = new System.Drawing.Size(839, 57);
            this.Pnl_marcosdetrabajo.TabIndex = 4;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_titulo.Location = new System.Drawing.Point(201, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(479, 44);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Asignar Marco de Trabajo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(753, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_asignarmarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(839, 665);
            this.Controls.Add(this.Pnl_marcosdetrabajo);
            this.Controls.Add(this.Nav_marcosdetrabajo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_asignarmarco";
            this.Text = "Asignar Marco de Trabajo";
            this.Pnl_marcosdetrabajo.ResumeLayout(false);
            this.Pnl_marcosdetrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_marcosdetrabajo;
        private System.Windows.Forms.Panel Pnl_marcosdetrabajo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}