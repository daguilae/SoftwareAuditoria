namespace MarcosDeTrabajoCV
{
    partial class Frm_registrarmarco
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Tbc_gestionmarcos = new System.Windows.Forms.TabControl();
            this.Tbp_marcosdetrabajo = new System.Windows.Forms.TabPage();
            this.Dgv_marcosdetrabajo = new System.Windows.Forms.DataGridView();
            this.Btn_nuevon = new System.Windows.Forms.Button();
            this.Btn_eliminare = new System.Windows.Forms.Button();
            this.Btn_modificarm = new System.Windows.Forms.Button();
            this.Btn_agregarm = new System.Windows.Forms.Button();
            this.Cbo_estadomarco = new System.Windows.Forms.ComboBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_nombremarco = new System.Windows.Forms.TextBox();
            this.Txt_codigomarco = new System.Windows.Forms.TextBox();
            this.Lbl_estadomarco = new System.Windows.Forms.Label();
            this.Lbl_descripcionmarco = new System.Windows.Forms.Label();
            this.Lbl_nombremarco = new System.Windows.Forms.Label();
            this.Lbl_codigomarco = new System.Windows.Forms.Label();
            this.Tbp_procesos = new System.Windows.Forms.TabPage();
            this.Cbo_seleccionmarcop = new System.Windows.Forms.ComboBox();
            this.Dgv_procesos = new System.Windows.Forms.DataGridView();
            this.Btn_nuevop = new System.Windows.Forms.Button();
            this.Btn_eliminarp = new System.Windows.Forms.Button();
            this.Btn_modificarp = new System.Windows.Forms.Button();
            this.Btn_agregarp = new System.Windows.Forms.Button();
            this.Cbo_estadoproceso = new System.Windows.Forms.ComboBox();
            this.Txt_nombreproceso = new System.Windows.Forms.TextBox();
            this.Txt_codigoproceso = new System.Windows.Forms.TextBox();
            this.Lbl_estadoproceso = new System.Windows.Forms.Label();
            this.Lbl_nombreproceso = new System.Windows.Forms.Label();
            this.Lbl_codigoproceso = new System.Windows.Forms.Label();
            this.Lbl_seleccionemarcop = new System.Windows.Forms.Label();
            this.Tbp_objetivos = new System.Windows.Forms.TabPage();
            this.Txt_descripcionobjetivo = new System.Windows.Forms.TextBox();
            this.Lbl_descripcionobjetivo = new System.Windows.Forms.Label();
            this.Cbo_proceso = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccioneproceso = new System.Windows.Forms.Label();
            this.Cbo_seleccionemarcoo = new System.Windows.Forms.ComboBox();
            this.Cbo_estadoobjetivo = new System.Windows.Forms.ComboBox();
            this.Txt_nombreobjetivo = new System.Windows.Forms.TextBox();
            this.Txt_codigoobjetivo = new System.Windows.Forms.TextBox();
            this.Lbl_estadoobjetivo = new System.Windows.Forms.Label();
            this.Lbl_nombreobjetivo = new System.Windows.Forms.Label();
            this.Lbl_codigoobjetivo = new System.Windows.Forms.Label();
            this.Lbl_seleccionemarcoo = new System.Windows.Forms.Label();
            this.Dgv_objetivos = new System.Windows.Forms.DataGridView();
            this.Btn_nuevoo = new System.Windows.Forms.Button();
            this.Btn_eliminaro = new System.Windows.Forms.Button();
            this.Btn_modificaro = new System.Windows.Forms.Button();
            this.Btn_agregaro = new System.Windows.Forms.Button();
            this.Pnl_marcosdetrabajo = new System.Windows.Forms.Panel();
            this.Tbc_gestionmarcos.SuspendLayout();
            this.Tbp_marcosdetrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_marcosdetrabajo)).BeginInit();
            this.Tbp_procesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_procesos)).BeginInit();
            this.Tbp_objetivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_objetivos)).BeginInit();
            this.Pnl_marcosdetrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_titulo.Location = new System.Drawing.Point(180, 7);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(498, 44);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Gestión Marcos de Trabajo";
            // 
            // Tbc_gestionmarcos
            // 
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_marcosdetrabajo);
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_procesos);
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_objetivos);
            this.Tbc_gestionmarcos.Location = new System.Drawing.Point(29, 81);
            this.Tbc_gestionmarcos.Name = "Tbc_gestionmarcos";
            this.Tbc_gestionmarcos.SelectedIndex = 0;
            this.Tbc_gestionmarcos.Size = new System.Drawing.Size(811, 470);
            this.Tbc_gestionmarcos.TabIndex = 1;
            // 
            // Tbp_marcosdetrabajo
            // 
            this.Tbp_marcosdetrabajo.Controls.Add(this.Dgv_marcosdetrabajo);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_nuevon);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_eliminare);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_modificarm);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_agregarm);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Cbo_estadomarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Txt_descripcion);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Txt_nombremarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Txt_codigomarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_estadomarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_descripcionmarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_nombremarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_codigomarco);
            this.Tbp_marcosdetrabajo.Location = new System.Drawing.Point(4, 30);
            this.Tbp_marcosdetrabajo.Name = "Tbp_marcosdetrabajo";
            this.Tbp_marcosdetrabajo.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_marcosdetrabajo.Size = new System.Drawing.Size(803, 436);
            this.Tbp_marcosdetrabajo.TabIndex = 0;
            this.Tbp_marcosdetrabajo.Text = "Marcos de Trabajo";
            this.Tbp_marcosdetrabajo.UseVisualStyleBackColor = true;
            // 
            // Dgv_marcosdetrabajo
            // 
            this.Dgv_marcosdetrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_marcosdetrabajo.Location = new System.Drawing.Point(17, 255);
            this.Dgv_marcosdetrabajo.Name = "Dgv_marcosdetrabajo";
            this.Dgv_marcosdetrabajo.Size = new System.Drawing.Size(767, 166);
            this.Dgv_marcosdetrabajo.TabIndex = 12;
            // 
            // Btn_nuevon
            // 
            this.Btn_nuevon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevon.ForeColor = System.Drawing.Color.Black;
            this.Btn_nuevon.Location = new System.Drawing.Point(560, 159);
            this.Btn_nuevon.Name = "Btn_nuevon";
            this.Btn_nuevon.Size = new System.Drawing.Size(111, 38);
            this.Btn_nuevon.TabIndex = 11;
            this.Btn_nuevon.Text = "Nuevo";
            this.Btn_nuevon.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminare
            // 
            this.Btn_eliminare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminare.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminare.Location = new System.Drawing.Point(560, 115);
            this.Btn_eliminare.Name = "Btn_eliminare";
            this.Btn_eliminare.Size = new System.Drawing.Size(111, 38);
            this.Btn_eliminare.TabIndex = 10;
            this.Btn_eliminare.Text = "Eliminar";
            this.Btn_eliminare.UseVisualStyleBackColor = false;
            // 
            // Btn_modificarm
            // 
            this.Btn_modificarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificarm.ForeColor = System.Drawing.Color.Black;
            this.Btn_modificarm.Location = new System.Drawing.Point(560, 67);
            this.Btn_modificarm.Name = "Btn_modificarm";
            this.Btn_modificarm.Size = new System.Drawing.Size(111, 38);
            this.Btn_modificarm.TabIndex = 9;
            this.Btn_modificarm.Text = "Modificar";
            this.Btn_modificarm.UseVisualStyleBackColor = false;
            // 
            // Btn_agregarm
            // 
            this.Btn_agregarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregarm.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregarm.Location = new System.Drawing.Point(560, 23);
            this.Btn_agregarm.Name = "Btn_agregarm";
            this.Btn_agregarm.Size = new System.Drawing.Size(111, 38);
            this.Btn_agregarm.TabIndex = 8;
            this.Btn_agregarm.Text = "Agregar";
            this.Btn_agregarm.UseVisualStyleBackColor = false;
            // 
            // Cbo_estadomarco
            // 
            this.Cbo_estadomarco.FormattingEnabled = true;
            this.Cbo_estadomarco.Location = new System.Drawing.Point(255, 203);
            this.Cbo_estadomarco.Name = "Cbo_estadomarco";
            this.Cbo_estadomarco.Size = new System.Drawing.Size(240, 29);
            this.Cbo_estadomarco.TabIndex = 7;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(255, 108);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(240, 82);
            this.Txt_descripcion.TabIndex = 6;
            // 
            // Txt_nombremarco
            // 
            this.Txt_nombremarco.Location = new System.Drawing.Point(255, 67);
            this.Txt_nombremarco.Name = "Txt_nombremarco";
            this.Txt_nombremarco.Size = new System.Drawing.Size(240, 27);
            this.Txt_nombremarco.TabIndex = 5;
            this.Txt_nombremarco.TextChanged += new System.EventHandler(this.Txt_nombremarco_TextChanged);
            // 
            // Txt_codigomarco
            // 
            this.Txt_codigomarco.Location = new System.Drawing.Point(255, 28);
            this.Txt_codigomarco.Name = "Txt_codigomarco";
            this.Txt_codigomarco.Size = new System.Drawing.Size(240, 27);
            this.Txt_codigomarco.TabIndex = 4;
            // 
            // Lbl_estadomarco
            // 
            this.Lbl_estadomarco.AutoSize = true;
            this.Lbl_estadomarco.Location = new System.Drawing.Point(185, 203);
            this.Lbl_estadomarco.Name = "Lbl_estadomarco";
            this.Lbl_estadomarco.Size = new System.Drawing.Size(64, 21);
            this.Lbl_estadomarco.TabIndex = 3;
            this.Lbl_estadomarco.Text = "Estado";
            // 
            // Lbl_descripcionmarco
            // 
            this.Lbl_descripcionmarco.AutoSize = true;
            this.Lbl_descripcionmarco.Location = new System.Drawing.Point(149, 108);
            this.Lbl_descripcionmarco.Name = "Lbl_descripcionmarco";
            this.Lbl_descripcionmarco.Size = new System.Drawing.Size(100, 21);
            this.Lbl_descripcionmarco.TabIndex = 2;
            this.Lbl_descripcionmarco.Text = "Descripción";
            // 
            // Lbl_nombremarco
            // 
            this.Lbl_nombremarco.AutoSize = true;
            this.Lbl_nombremarco.Location = new System.Drawing.Point(93, 67);
            this.Lbl_nombremarco.Name = "Lbl_nombremarco";
            this.Lbl_nombremarco.Size = new System.Drawing.Size(156, 21);
            this.Lbl_nombremarco.TabIndex = 1;
            this.Lbl_nombremarco.Text = "Nombre del Marco";
            this.Lbl_nombremarco.Click += new System.EventHandler(this.Lbl_nombremarco_Click);
            // 
            // Lbl_codigomarco
            // 
            this.Lbl_codigomarco.AutoSize = true;
            this.Lbl_codigomarco.Location = new System.Drawing.Point(181, 28);
            this.Lbl_codigomarco.Name = "Lbl_codigomarco";
            this.Lbl_codigomarco.Size = new System.Drawing.Size(68, 21);
            this.Lbl_codigomarco.TabIndex = 0;
            this.Lbl_codigomarco.Text = "Código";
            this.Lbl_codigomarco.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tbp_procesos
            // 
            this.Tbp_procesos.Controls.Add(this.Cbo_seleccionmarcop);
            this.Tbp_procesos.Controls.Add(this.Dgv_procesos);
            this.Tbp_procesos.Controls.Add(this.Btn_nuevop);
            this.Tbp_procesos.Controls.Add(this.Btn_eliminarp);
            this.Tbp_procesos.Controls.Add(this.Btn_modificarp);
            this.Tbp_procesos.Controls.Add(this.Btn_agregarp);
            this.Tbp_procesos.Controls.Add(this.Cbo_estadoproceso);
            this.Tbp_procesos.Controls.Add(this.Txt_nombreproceso);
            this.Tbp_procesos.Controls.Add(this.Txt_codigoproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_estadoproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_nombreproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_codigoproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_seleccionemarcop);
            this.Tbp_procesos.Location = new System.Drawing.Point(4, 30);
            this.Tbp_procesos.Name = "Tbp_procesos";
            this.Tbp_procesos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_procesos.Size = new System.Drawing.Size(803, 436);
            this.Tbp_procesos.TabIndex = 1;
            this.Tbp_procesos.Text = "Procesos";
            this.Tbp_procesos.UseVisualStyleBackColor = true;
            // 
            // Cbo_seleccionmarcop
            // 
            this.Cbo_seleccionmarcop.FormattingEnabled = true;
            this.Cbo_seleccionmarcop.Location = new System.Drawing.Point(274, 31);
            this.Cbo_seleccionmarcop.Name = "Cbo_seleccionmarcop";
            this.Cbo_seleccionmarcop.Size = new System.Drawing.Size(240, 29);
            this.Cbo_seleccionmarcop.TabIndex = 26;
            // 
            // Dgv_procesos
            // 
            this.Dgv_procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_procesos.Location = new System.Drawing.Point(17, 255);
            this.Dgv_procesos.Name = "Dgv_procesos";
            this.Dgv_procesos.Size = new System.Drawing.Size(767, 166);
            this.Dgv_procesos.TabIndex = 25;
            // 
            // Btn_nuevop
            // 
            this.Btn_nuevop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevop.Location = new System.Drawing.Point(560, 159);
            this.Btn_nuevop.Name = "Btn_nuevop";
            this.Btn_nuevop.Size = new System.Drawing.Size(111, 38);
            this.Btn_nuevop.TabIndex = 24;
            this.Btn_nuevop.Text = "Nuevo";
            this.Btn_nuevop.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminarp
            // 
            this.Btn_eliminarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminarp.Location = new System.Drawing.Point(560, 115);
            this.Btn_eliminarp.Name = "Btn_eliminarp";
            this.Btn_eliminarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_eliminarp.TabIndex = 23;
            this.Btn_eliminarp.Text = "Eliminar";
            this.Btn_eliminarp.UseVisualStyleBackColor = false;
            // 
            // Btn_modificarp
            // 
            this.Btn_modificarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificarp.Location = new System.Drawing.Point(560, 67);
            this.Btn_modificarp.Name = "Btn_modificarp";
            this.Btn_modificarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_modificarp.TabIndex = 22;
            this.Btn_modificarp.Text = "Modificar";
            this.Btn_modificarp.UseVisualStyleBackColor = false;
            // 
            // Btn_agregarp
            // 
            this.Btn_agregarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarp.Location = new System.Drawing.Point(560, 23);
            this.Btn_agregarp.Name = "Btn_agregarp";
            this.Btn_agregarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_agregarp.TabIndex = 21;
            this.Btn_agregarp.Text = "Agregar";
            this.Btn_agregarp.UseVisualStyleBackColor = false;
            // 
            // Cbo_estadoproceso
            // 
            this.Cbo_estadoproceso.FormattingEnabled = true;
            this.Cbo_estadoproceso.Location = new System.Drawing.Point(274, 177);
            this.Cbo_estadoproceso.Name = "Cbo_estadoproceso";
            this.Cbo_estadoproceso.Size = new System.Drawing.Size(240, 29);
            this.Cbo_estadoproceso.TabIndex = 20;
            // 
            // Txt_nombreproceso
            // 
            this.Txt_nombreproceso.Location = new System.Drawing.Point(274, 126);
            this.Txt_nombreproceso.Name = "Txt_nombreproceso";
            this.Txt_nombreproceso.Size = new System.Drawing.Size(240, 27);
            this.Txt_nombreproceso.TabIndex = 19;
            // 
            // Txt_codigoproceso
            // 
            this.Txt_codigoproceso.Location = new System.Drawing.Point(274, 78);
            this.Txt_codigoproceso.Name = "Txt_codigoproceso";
            this.Txt_codigoproceso.Size = new System.Drawing.Size(240, 27);
            this.Txt_codigoproceso.TabIndex = 18;
            // 
            // Lbl_estadoproceso
            // 
            this.Lbl_estadoproceso.AutoSize = true;
            this.Lbl_estadoproceso.Location = new System.Drawing.Point(184, 177);
            this.Lbl_estadoproceso.Name = "Lbl_estadoproceso";
            this.Lbl_estadoproceso.Size = new System.Drawing.Size(64, 21);
            this.Lbl_estadoproceso.TabIndex = 16;
            this.Lbl_estadoproceso.Text = "Estado";
            // 
            // Lbl_nombreproceso
            // 
            this.Lbl_nombreproceso.AutoSize = true;
            this.Lbl_nombreproceso.Location = new System.Drawing.Point(90, 126);
            this.Lbl_nombreproceso.Name = "Lbl_nombreproceso";
            this.Lbl_nombreproceso.Size = new System.Drawing.Size(165, 21);
            this.Lbl_nombreproceso.TabIndex = 15;
            this.Lbl_nombreproceso.Text = "Nombre del Proceso";
            // 
            // Lbl_codigoproceso
            // 
            this.Lbl_codigoproceso.AutoSize = true;
            this.Lbl_codigoproceso.Location = new System.Drawing.Point(97, 78);
            this.Lbl_codigoproceso.Name = "Lbl_codigoproceso";
            this.Lbl_codigoproceso.Size = new System.Drawing.Size(160, 21);
            this.Lbl_codigoproceso.TabIndex = 14;
            this.Lbl_codigoproceso.Text = "Código del Proceso";
            // 
            // Lbl_seleccionemarcop
            // 
            this.Lbl_seleccionemarcop.AutoSize = true;
            this.Lbl_seleccionemarcop.Location = new System.Drawing.Point(31, 31);
            this.Lbl_seleccionemarcop.Name = "Lbl_seleccionemarcop";
            this.Lbl_seleccionemarcop.Size = new System.Drawing.Size(237, 21);
            this.Lbl_seleccionemarcop.TabIndex = 13;
            this.Lbl_seleccionemarcop.Text = "Seleccione Marco de Trabajo";
            // 
            // Tbp_objetivos
            // 
            this.Tbp_objetivos.Controls.Add(this.Txt_descripcionobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Lbl_descripcionobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Cbo_proceso);
            this.Tbp_objetivos.Controls.Add(this.Lbl_seleccioneproceso);
            this.Tbp_objetivos.Controls.Add(this.Cbo_seleccionemarcoo);
            this.Tbp_objetivos.Controls.Add(this.Cbo_estadoobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Txt_nombreobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Txt_codigoobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Lbl_estadoobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Lbl_nombreobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Lbl_codigoobjetivo);
            this.Tbp_objetivos.Controls.Add(this.Lbl_seleccionemarcoo);
            this.Tbp_objetivos.Controls.Add(this.Dgv_objetivos);
            this.Tbp_objetivos.Controls.Add(this.Btn_nuevoo);
            this.Tbp_objetivos.Controls.Add(this.Btn_eliminaro);
            this.Tbp_objetivos.Controls.Add(this.Btn_modificaro);
            this.Tbp_objetivos.Controls.Add(this.Btn_agregaro);
            this.Tbp_objetivos.Location = new System.Drawing.Point(4, 30);
            this.Tbp_objetivos.Name = "Tbp_objetivos";
            this.Tbp_objetivos.Size = new System.Drawing.Size(803, 436);
            this.Tbp_objetivos.TabIndex = 2;
            this.Tbp_objetivos.Text = "Objetivos";
            this.Tbp_objetivos.UseVisualStyleBackColor = true;
            this.Tbp_objetivos.Click += new System.EventHandler(this.Tbp_objetivos_Click);
            // 
            // Txt_descripcionobjetivo
            // 
            this.Txt_descripcionobjetivo.Location = new System.Drawing.Point(267, 157);
            this.Txt_descripcionobjetivo.Multiline = true;
            this.Txt_descripcionobjetivo.Name = "Txt_descripcionobjetivo";
            this.Txt_descripcionobjetivo.Size = new System.Drawing.Size(240, 50);
            this.Txt_descripcionobjetivo.TabIndex = 38;
            // 
            // Lbl_descripcionobjetivo
            // 
            this.Lbl_descripcionobjetivo.AutoSize = true;
            this.Lbl_descripcionobjetivo.Location = new System.Drawing.Point(161, 157);
            this.Lbl_descripcionobjetivo.Name = "Lbl_descripcionobjetivo";
            this.Lbl_descripcionobjetivo.Size = new System.Drawing.Size(100, 21);
            this.Lbl_descripcionobjetivo.TabIndex = 37;
            this.Lbl_descripcionobjetivo.Text = "Descripción";
            // 
            // Cbo_proceso
            // 
            this.Cbo_proceso.FormattingEnabled = true;
            this.Cbo_proceso.Location = new System.Drawing.Point(267, 48);
            this.Cbo_proceso.Name = "Cbo_proceso";
            this.Cbo_proceso.Size = new System.Drawing.Size(240, 29);
            this.Cbo_proceso.TabIndex = 36;
            // 
            // Lbl_seleccioneproceso
            // 
            this.Lbl_seleccioneproceso.AutoSize = true;
            this.Lbl_seleccioneproceso.Location = new System.Drawing.Point(79, 48);
            this.Lbl_seleccioneproceso.Name = "Lbl_seleccioneproceso";
            this.Lbl_seleccioneproceso.Size = new System.Drawing.Size(182, 21);
            this.Lbl_seleccioneproceso.TabIndex = 35;
            this.Lbl_seleccioneproceso.Text = "Seleccione un Proceso";
            // 
            // Cbo_seleccionemarcoo
            // 
            this.Cbo_seleccionemarcoo.FormattingEnabled = true;
            this.Cbo_seleccionemarcoo.Location = new System.Drawing.Point(267, 11);
            this.Cbo_seleccionemarcoo.Name = "Cbo_seleccionemarcoo";
            this.Cbo_seleccionemarcoo.Size = new System.Drawing.Size(240, 29);
            this.Cbo_seleccionemarcoo.TabIndex = 34;
            // 
            // Cbo_estadoobjetivo
            // 
            this.Cbo_estadoobjetivo.FormattingEnabled = true;
            this.Cbo_estadoobjetivo.Location = new System.Drawing.Point(267, 214);
            this.Cbo_estadoobjetivo.Name = "Cbo_estadoobjetivo";
            this.Cbo_estadoobjetivo.Size = new System.Drawing.Size(240, 29);
            this.Cbo_estadoobjetivo.TabIndex = 33;
            // 
            // Txt_nombreobjetivo
            // 
            this.Txt_nombreobjetivo.Location = new System.Drawing.Point(267, 122);
            this.Txt_nombreobjetivo.Name = "Txt_nombreobjetivo";
            this.Txt_nombreobjetivo.Size = new System.Drawing.Size(240, 27);
            this.Txt_nombreobjetivo.TabIndex = 32;
            // 
            // Txt_codigoobjetivo
            // 
            this.Txt_codigoobjetivo.Location = new System.Drawing.Point(267, 85);
            this.Txt_codigoobjetivo.Name = "Txt_codigoobjetivo";
            this.Txt_codigoobjetivo.Size = new System.Drawing.Size(240, 27);
            this.Txt_codigoobjetivo.TabIndex = 31;
            // 
            // Lbl_estadoobjetivo
            // 
            this.Lbl_estadoobjetivo.AutoSize = true;
            this.Lbl_estadoobjetivo.Location = new System.Drawing.Point(197, 214);
            this.Lbl_estadoobjetivo.Name = "Lbl_estadoobjetivo";
            this.Lbl_estadoobjetivo.Size = new System.Drawing.Size(64, 21);
            this.Lbl_estadoobjetivo.TabIndex = 30;
            this.Lbl_estadoobjetivo.Text = "Estado";
            // 
            // Lbl_nombreobjetivo
            // 
            this.Lbl_nombreobjetivo.AutoSize = true;
            this.Lbl_nombreobjetivo.Location = new System.Drawing.Point(90, 122);
            this.Lbl_nombreobjetivo.Name = "Lbl_nombreobjetivo";
            this.Lbl_nombreobjetivo.Size = new System.Drawing.Size(173, 21);
            this.Lbl_nombreobjetivo.TabIndex = 29;
            this.Lbl_nombreobjetivo.Text = "Nombre del Objetivo";
            // 
            // Lbl_codigoobjetivo
            // 
            this.Lbl_codigoobjetivo.AutoSize = true;
            this.Lbl_codigoobjetivo.Location = new System.Drawing.Point(97, 85);
            this.Lbl_codigoobjetivo.Name = "Lbl_codigoobjetivo";
            this.Lbl_codigoobjetivo.Size = new System.Drawing.Size(168, 21);
            this.Lbl_codigoobjetivo.TabIndex = 28;
            this.Lbl_codigoobjetivo.Text = "Código del Objetivo";
            // 
            // Lbl_seleccionemarcoo
            // 
            this.Lbl_seleccionemarcoo.AutoSize = true;
            this.Lbl_seleccionemarcoo.Location = new System.Drawing.Point(24, 11);
            this.Lbl_seleccionemarcoo.Name = "Lbl_seleccionemarcoo";
            this.Lbl_seleccionemarcoo.Size = new System.Drawing.Size(237, 21);
            this.Lbl_seleccionemarcoo.TabIndex = 27;
            this.Lbl_seleccionemarcoo.Text = "Seleccione Marco de Trabajo";
            // 
            // Dgv_objetivos
            // 
            this.Dgv_objetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_objetivos.Location = new System.Drawing.Point(17, 255);
            this.Dgv_objetivos.Name = "Dgv_objetivos";
            this.Dgv_objetivos.Size = new System.Drawing.Size(767, 166);
            this.Dgv_objetivos.TabIndex = 25;
            // 
            // Btn_nuevoo
            // 
            this.Btn_nuevoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevoo.Location = new System.Drawing.Point(560, 159);
            this.Btn_nuevoo.Name = "Btn_nuevoo";
            this.Btn_nuevoo.Size = new System.Drawing.Size(111, 38);
            this.Btn_nuevoo.TabIndex = 24;
            this.Btn_nuevoo.Text = "Nuevo";
            this.Btn_nuevoo.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminaro
            // 
            this.Btn_eliminaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminaro.Location = new System.Drawing.Point(560, 115);
            this.Btn_eliminaro.Name = "Btn_eliminaro";
            this.Btn_eliminaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_eliminaro.TabIndex = 23;
            this.Btn_eliminaro.Text = "Eliminar";
            this.Btn_eliminaro.UseVisualStyleBackColor = false;
            // 
            // Btn_modificaro
            // 
            this.Btn_modificaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificaro.Location = new System.Drawing.Point(560, 67);
            this.Btn_modificaro.Name = "Btn_modificaro";
            this.Btn_modificaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_modificaro.TabIndex = 22;
            this.Btn_modificaro.Text = "Modificar";
            this.Btn_modificaro.UseVisualStyleBackColor = false;
            // 
            // Btn_agregaro
            // 
            this.Btn_agregaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregaro.Location = new System.Drawing.Point(560, 23);
            this.Btn_agregaro.Name = "Btn_agregaro";
            this.Btn_agregaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_agregaro.TabIndex = 21;
            this.Btn_agregaro.Text = "Agregar";
            this.Btn_agregaro.UseVisualStyleBackColor = false;
            // 
            // Pnl_marcosdetrabajo
            // 
            this.Pnl_marcosdetrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Pnl_marcosdetrabajo.Controls.Add(this.Lbl_titulo);
            this.Pnl_marcosdetrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_marcosdetrabajo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_marcosdetrabajo.Name = "Pnl_marcosdetrabajo";
            this.Pnl_marcosdetrabajo.Size = new System.Drawing.Size(882, 55);
            this.Pnl_marcosdetrabajo.TabIndex = 2;
            // 
            // Frm_registrarmarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.Pnl_marcosdetrabajo);
            this.Controls.Add(this.Tbc_gestionmarcos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_registrarmarco";
            this.Text = "Gestión de Marcos de Trabajo";
            this.Tbc_gestionmarcos.ResumeLayout(false);
            this.Tbp_marcosdetrabajo.ResumeLayout(false);
            this.Tbp_marcosdetrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_marcosdetrabajo)).EndInit();
            this.Tbp_procesos.ResumeLayout(false);
            this.Tbp_procesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_procesos)).EndInit();
            this.Tbp_objetivos.ResumeLayout(false);
            this.Tbp_objetivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_objetivos)).EndInit();
            this.Pnl_marcosdetrabajo.ResumeLayout(false);
            this.Pnl_marcosdetrabajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TabControl Tbc_gestionmarcos;
        private System.Windows.Forms.TabPage Tbp_marcosdetrabajo;
        private System.Windows.Forms.Label Lbl_codigomarco;
        private System.Windows.Forms.TabPage Tbp_procesos;
        private System.Windows.Forms.TabPage Tbp_objetivos;
        private System.Windows.Forms.TextBox Txt_codigomarco;
        private System.Windows.Forms.Label Lbl_estadomarco;
        private System.Windows.Forms.Label Lbl_descripcionmarco;
        private System.Windows.Forms.Label Lbl_nombremarco;
        private System.Windows.Forms.TextBox Txt_nombremarco;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.ComboBox Cbo_estadomarco;
        private System.Windows.Forms.DataGridView Dgv_marcosdetrabajo;
        private System.Windows.Forms.Button Btn_nuevon;
        private System.Windows.Forms.Button Btn_eliminare;
        private System.Windows.Forms.Button Btn_modificarm;
        private System.Windows.Forms.Button Btn_agregarm;
        private System.Windows.Forms.DataGridView Dgv_procesos;
        private System.Windows.Forms.Button Btn_nuevop;
        private System.Windows.Forms.Button Btn_eliminarp;
        private System.Windows.Forms.Button Btn_modificarp;
        private System.Windows.Forms.Button Btn_agregarp;
        private System.Windows.Forms.ComboBox Cbo_estadoproceso;
        private System.Windows.Forms.TextBox Txt_nombreproceso;
        private System.Windows.Forms.TextBox Txt_codigoproceso;
        private System.Windows.Forms.Label Lbl_estadoproceso;
        private System.Windows.Forms.Label Lbl_nombreproceso;
        private System.Windows.Forms.Label Lbl_codigoproceso;
        private System.Windows.Forms.Label Lbl_seleccionemarcop;
        private System.Windows.Forms.DataGridView Dgv_objetivos;
        private System.Windows.Forms.Button Btn_nuevoo;
        private System.Windows.Forms.Button Btn_eliminaro;
        private System.Windows.Forms.Button Btn_modificaro;
        private System.Windows.Forms.Button Btn_agregaro;
        private System.Windows.Forms.ComboBox Cbo_seleccionmarcop;
        private System.Windows.Forms.TextBox Txt_descripcionobjetivo;
        private System.Windows.Forms.Label Lbl_descripcionobjetivo;
        private System.Windows.Forms.ComboBox Cbo_proceso;
        private System.Windows.Forms.Label Lbl_seleccioneproceso;
        private System.Windows.Forms.ComboBox Cbo_seleccionemarcoo;
        private System.Windows.Forms.ComboBox Cbo_estadoobjetivo;
        private System.Windows.Forms.TextBox Txt_nombreobjetivo;
        private System.Windows.Forms.TextBox Txt_codigoobjetivo;
        private System.Windows.Forms.Label Lbl_estadoobjetivo;
        private System.Windows.Forms.Label Lbl_nombreobjetivo;
        private System.Windows.Forms.Label Lbl_codigoobjetivo;
        private System.Windows.Forms.Label Lbl_seleccionemarcoo;
        private System.Windows.Forms.Panel Pnl_marcosdetrabajo;
    }
}