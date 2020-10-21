namespace GestionProyecto
{
    partial class Frm_Evaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Evaluacion));
            this.Dtv_Resultados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lbl_AspectoaEvaluar = new System.Windows.Forms.Label();
            this.Lbl_MarcodeTrabajo = new System.Windows.Forms.Label();
            this.Lbl_GrupoaEvaluar = new System.Windows.Forms.Label();
            this.Lbl_TipodeAuditoria = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Gpb_General = new System.Windows.Forms.GroupBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Resultados)).BeginInit();
            this.Gpb_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtv_Resultados
            // 
            this.Dtv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_Resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dtv_Resultados.Location = new System.Drawing.Point(28, 315);
            this.Dtv_Resultados.Name = "Dtv_Resultados";
            this.Dtv_Resultados.Size = new System.Drawing.Size(652, 303);
            this.Dtv_Resultados.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Caracteristica";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valoración";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Punteo";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(334, 126);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(247, 27);
            this.textBox6.TabIndex = 24;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(333, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(247, 27);
            this.textBox5.TabIndex = 23;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(23, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(266, 27);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(24, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 27);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Lbl_AspectoaEvaluar
            // 
            this.Lbl_AspectoaEvaluar.AutoSize = true;
            this.Lbl_AspectoaEvaluar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AspectoaEvaluar.Location = new System.Drawing.Point(330, 93);
            this.Lbl_AspectoaEvaluar.Name = "Lbl_AspectoaEvaluar";
            this.Lbl_AspectoaEvaluar.Size = new System.Drawing.Size(155, 21);
            this.Lbl_AspectoaEvaluar.TabIndex = 20;
            this.Lbl_AspectoaEvaluar.Text = "Aspecto a Evaluar";
            this.Lbl_AspectoaEvaluar.Click += new System.EventHandler(this.label6_Click);
            // 
            // Lbl_MarcodeTrabajo
            // 
            this.Lbl_MarcodeTrabajo.AutoSize = true;
            this.Lbl_MarcodeTrabajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MarcodeTrabajo.Location = new System.Drawing.Point(330, 11);
            this.Lbl_MarcodeTrabajo.Name = "Lbl_MarcodeTrabajo";
            this.Lbl_MarcodeTrabajo.Size = new System.Drawing.Size(149, 21);
            this.Lbl_MarcodeTrabajo.TabIndex = 19;
            this.Lbl_MarcodeTrabajo.Text = "Marco de Trabajo";
            this.Lbl_MarcodeTrabajo.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lbl_GrupoaEvaluar
            // 
            this.Lbl_GrupoaEvaluar.AutoSize = true;
            this.Lbl_GrupoaEvaluar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GrupoaEvaluar.Location = new System.Drawing.Point(23, 169);
            this.Lbl_GrupoaEvaluar.Name = "Lbl_GrupoaEvaluar";
            this.Lbl_GrupoaEvaluar.Size = new System.Drawing.Size(138, 21);
            this.Lbl_GrupoaEvaluar.TabIndex = 18;
            this.Lbl_GrupoaEvaluar.Text = "Grupo a Evaluar";
            this.Lbl_GrupoaEvaluar.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbl_TipodeAuditoria
            // 
            this.Lbl_TipodeAuditoria.AutoSize = true;
            this.Lbl_TipodeAuditoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipodeAuditoria.Location = new System.Drawing.Point(20, 93);
            this.Lbl_TipodeAuditoria.Name = "Lbl_TipodeAuditoria";
            this.Lbl_TipodeAuditoria.Size = new System.Drawing.Size(144, 21);
            this.Lbl_TipodeAuditoria.TabIndex = 17;
            this.Lbl_TipodeAuditoria.Text = "Tipo de Auditoria";
            this.Lbl_TipodeAuditoria.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(333, 205);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(247, 27);
            this.textBox7.TabIndex = 33;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(330, 169);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(49, 21);
            this.Lbl_Total.TabIndex = 32;
            this.Lbl_Total.Text = "Total";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(23, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(266, 27);
            this.textBox8.TabIndex = 31;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID.Location = new System.Drawing.Point(20, 11);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(118, 21);
            this.Lbl_ID.TabIndex = 30;
            this.Lbl_ID.Text = "ID Evaluación";
            // 
            // Gpb_General
            // 
            this.Gpb_General.Controls.Add(this.Btn_Calcular);
            this.Gpb_General.Controls.Add(this.textBox7);
            this.Gpb_General.Controls.Add(this.Lbl_Total);
            this.Gpb_General.Controls.Add(this.textBox8);
            this.Gpb_General.Controls.Add(this.Lbl_ID);
            this.Gpb_General.Controls.Add(this.Lbl_TipodeAuditoria);
            this.Gpb_General.Controls.Add(this.textBox6);
            this.Gpb_General.Controls.Add(this.Lbl_GrupoaEvaluar);
            this.Gpb_General.Controls.Add(this.textBox5);
            this.Gpb_General.Controls.Add(this.Lbl_MarcodeTrabajo);
            this.Gpb_General.Controls.Add(this.textBox4);
            this.Gpb_General.Controls.Add(this.Lbl_AspectoaEvaluar);
            this.Gpb_General.Controls.Add(this.textBox3);
            this.Gpb_General.Location = new System.Drawing.Point(28, 32);
            this.Gpb_General.Name = "Gpb_General";
            this.Gpb_General.Size = new System.Drawing.Size(652, 262);
            this.Gpb_General.TabIndex = 34;
            this.Gpb_General.TabStop = false;
            this.Gpb_General.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
            this.Btn_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Calcular.Image")));
            this.Btn_Calcular.Location = new System.Drawing.Point(597, 205);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(37, 43);
            this.Btn_Calcular.TabIndex = 35;
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // Frm_Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(742, 676);
            this.Controls.Add(this.Gpb_General);
            this.Controls.Add(this.Dtv_Resultados);
            this.Name = "Frm_Evaluacion";
            this.Text = "Evaluacion";
            this.Load += new System.EventHandler(this.Frm_Evaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Resultados)).EndInit();
            this.Gpb_General.ResumeLayout(false);
            this.Gpb_General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtv_Resultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Lbl_AspectoaEvaluar;
        private System.Windows.Forms.Label Lbl_MarcodeTrabajo;
        private System.Windows.Forms.Label Lbl_GrupoaEvaluar;
        private System.Windows.Forms.Label Lbl_TipodeAuditoria;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.GroupBox Gpb_General;
        private System.Windows.Forms.Button Btn_Calcular;
    }
}