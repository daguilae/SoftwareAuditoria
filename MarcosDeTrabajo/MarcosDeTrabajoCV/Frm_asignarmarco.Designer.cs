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
            this.Pnl_marcosdetrabajo = new System.Windows.Forms.Panel();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Cbo_seleccioneproyecto = new System.Windows.Forms.ComboBox();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_asignar = new System.Windows.Forms.Button();
            this.Cbo_seleccionemarco = new System.Windows.Forms.ComboBox();
            this.Txt_codigoproceso = new System.Windows.Forms.TextBox();
            this.Lbl_estadoproceso = new System.Windows.Forms.Label();
            this.Lbl_seleccionemarcodetrabajo = new System.Windows.Forms.Label();
            this.Lbl_codigoasignacion = new System.Windows.Forms.Label();
            this.Lbl_seleccioneproyecto = new System.Windows.Forms.Label();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Pnl_marcosdetrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_marcosdetrabajo
            // 
            this.Pnl_marcosdetrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Pnl_marcosdetrabajo.Controls.Add(this.Lbl_titulo);
            this.Pnl_marcosdetrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_marcosdetrabajo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_marcosdetrabajo.Name = "Pnl_marcosdetrabajo";
            this.Pnl_marcosdetrabajo.Size = new System.Drawing.Size(792, 55);
            this.Pnl_marcosdetrabajo.TabIndex = 3;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_titulo.Location = new System.Drawing.Point(124, 5);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(561, 44);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Asignación Marcos de Trabajo";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // Cbo_seleccioneproyecto
            // 
            this.Cbo_seleccioneproyecto.FormattingEnabled = true;
            this.Cbo_seleccioneproyecto.Location = new System.Drawing.Point(270, 125);
            this.Cbo_seleccioneproyecto.Name = "Cbo_seleccioneproyecto";
            this.Cbo_seleccioneproyecto.Size = new System.Drawing.Size(240, 29);
            this.Cbo_seleccioneproyecto.TabIndex = 38;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevo.Location = new System.Drawing.Point(556, 217);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(111, 38);
            this.Btn_nuevo.TabIndex = 37;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(556, 173);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(111, 38);
            this.Btn_eliminar.TabIndex = 36;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Location = new System.Drawing.Point(556, 125);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(111, 38);
            this.Btn_modificar.TabIndex = 35;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_asignar
            // 
            this.Btn_asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_asignar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_asignar.Location = new System.Drawing.Point(556, 81);
            this.Btn_asignar.Name = "Btn_asignar";
            this.Btn_asignar.Size = new System.Drawing.Size(111, 38);
            this.Btn_asignar.TabIndex = 34;
            this.Btn_asignar.Text = "Asignar";
            this.Btn_asignar.UseVisualStyleBackColor = false;
            // 
            // Cbo_seleccionemarco
            // 
            this.Cbo_seleccionemarco.FormattingEnabled = true;
            this.Cbo_seleccionemarco.Location = new System.Drawing.Point(270, 173);
            this.Cbo_seleccionemarco.Name = "Cbo_seleccionemarco";
            this.Cbo_seleccionemarco.Size = new System.Drawing.Size(240, 29);
            this.Cbo_seleccionemarco.TabIndex = 33;
            // 
            // Txt_codigoproceso
            // 
            this.Txt_codigoproceso.Location = new System.Drawing.Point(270, 81);
            this.Txt_codigoproceso.Name = "Txt_codigoproceso";
            this.Txt_codigoproceso.Size = new System.Drawing.Size(240, 27);
            this.Txt_codigoproceso.TabIndex = 31;
            // 
            // Lbl_estadoproceso
            // 
            this.Lbl_estadoproceso.AutoSize = true;
            this.Lbl_estadoproceso.Location = new System.Drawing.Point(200, 217);
            this.Lbl_estadoproceso.Name = "Lbl_estadoproceso";
            this.Lbl_estadoproceso.Size = new System.Drawing.Size(64, 21);
            this.Lbl_estadoproceso.TabIndex = 30;
            this.Lbl_estadoproceso.Text = "Estado";
            // 
            // Lbl_seleccionemarcodetrabajo
            // 
            this.Lbl_seleccionemarcodetrabajo.AutoSize = true;
            this.Lbl_seleccionemarcodetrabajo.Location = new System.Drawing.Point(27, 173);
            this.Lbl_seleccionemarcodetrabajo.Name = "Lbl_seleccionemarcodetrabajo";
            this.Lbl_seleccionemarcodetrabajo.Size = new System.Drawing.Size(237, 21);
            this.Lbl_seleccionemarcodetrabajo.TabIndex = 29;
            this.Lbl_seleccionemarcodetrabajo.Text = "Seleccione Marco de Trabajo";
            // 
            // Lbl_codigoasignacion
            // 
            this.Lbl_codigoasignacion.AutoSize = true;
            this.Lbl_codigoasignacion.Location = new System.Drawing.Point(80, 81);
            this.Lbl_codigoasignacion.Name = "Lbl_codigoasignacion";
            this.Lbl_codigoasignacion.Size = new System.Drawing.Size(184, 21);
            this.Lbl_codigoasignacion.TabIndex = 28;
            this.Lbl_codigoasignacion.Text = "Código de Asignación";
            // 
            // Lbl_seleccioneproyecto
            // 
            this.Lbl_seleccioneproyecto.AutoSize = true;
            this.Lbl_seleccioneproyecto.Location = new System.Drawing.Point(97, 125);
            this.Lbl_seleccioneproyecto.Name = "Lbl_seleccioneproyecto";
            this.Lbl_seleccioneproyecto.Size = new System.Drawing.Size(167, 21);
            this.Lbl_seleccioneproyecto.TabIndex = 27;
            this.Lbl_seleccioneproyecto.Text = "Seleccione Proyecto";
            // 
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.Location = new System.Drawing.Point(13, 288);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.Size = new System.Drawing.Size(767, 166);
            this.Dgv_asignacion.TabIndex = 39;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Location = new System.Drawing.Point(270, 217);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(240, 29);
            this.Cbo_estado.TabIndex = 40;
            // 
            // Frm_asignarmarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 468);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Cbo_seleccioneproyecto);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_asignar);
            this.Controls.Add(this.Cbo_seleccionemarco);
            this.Controls.Add(this.Txt_codigoproceso);
            this.Controls.Add(this.Lbl_estadoproceso);
            this.Controls.Add(this.Lbl_seleccionemarcodetrabajo);
            this.Controls.Add(this.Lbl_codigoasignacion);
            this.Controls.Add(this.Lbl_seleccioneproyecto);
            this.Controls.Add(this.Pnl_marcosdetrabajo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_asignarmarco";
            this.Text = "Asignar Marcos de Trabajo";
            this.Pnl_marcosdetrabajo.ResumeLayout(false);
            this.Pnl_marcosdetrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_marcosdetrabajo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.ComboBox Cbo_seleccioneproyecto;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_asignar;
        private System.Windows.Forms.ComboBox Cbo_seleccionemarco;
        private System.Windows.Forms.TextBox Txt_codigoproceso;
        private System.Windows.Forms.Label Lbl_estadoproceso;
        private System.Windows.Forms.Label Lbl_seleccionemarcodetrabajo;
        private System.Windows.Forms.Label Lbl_codigoasignacion;
        private System.Windows.Forms.Label Lbl_seleccioneproyecto;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
        private System.Windows.Forms.ComboBox Cbo_estado;
    }
}