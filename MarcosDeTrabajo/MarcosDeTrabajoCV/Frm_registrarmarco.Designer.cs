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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_registrarmarco));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Tbc_gestionmarcos = new System.Windows.Forms.TabControl();
            this.Tbp_procesos = new System.Windows.Forms.TabPage();
            this.Btn_cancelarp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Descripción = new System.Windows.Forms.TextBox();
            this.Cbo_tipoproceso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Btn_cancelaro = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tbc_gestionmarcos.SuspendLayout();
            this.Tbp_procesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_procesos)).BeginInit();
            this.Tbp_objetivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_objetivos)).BeginInit();
            this.Pnl_marcosdetrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_procesos);
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_objetivos);
            this.Tbc_gestionmarcos.Location = new System.Drawing.Point(29, 81);
            this.Tbc_gestionmarcos.Name = "Tbc_gestionmarcos";
            this.Tbc_gestionmarcos.SelectedIndex = 0;
            this.Tbc_gestionmarcos.Size = new System.Drawing.Size(811, 470);
            this.Tbc_gestionmarcos.TabIndex = 1;
            this.Tbc_gestionmarcos.SelectedIndexChanged += new System.EventHandler(this.Tbc_gestionmarcos_SelectedIndexChanged);
            this.Tbc_gestionmarcos.TabIndexChanged += new System.EventHandler(this.Tbc_gestionmarcos_TabIndexChanged);
            // 
            // Tbp_procesos
            // 
            this.Tbp_procesos.Controls.Add(this.Btn_cancelarp);
            this.Tbp_procesos.Controls.Add(this.label2);
            this.Tbp_procesos.Controls.Add(this.Txt_Descripción);
            this.Tbp_procesos.Controls.Add(this.Cbo_tipoproceso);
            this.Tbp_procesos.Controls.Add(this.label1);
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
            // Btn_cancelarp
            // 
            this.Btn_cancelarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_cancelarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_cancelarp.FlatAppearance.BorderSize = 0;
            this.Btn_cancelarp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_cancelarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_cancelarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelarp.Location = new System.Drawing.Point(673, 161);
            this.Btn_cancelarp.Name = "Btn_cancelarp";
            this.Btn_cancelarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_cancelarp.TabIndex = 31;
            this.Btn_cancelarp.Text = "Cancelar";
            this.Btn_cancelarp.UseVisualStyleBackColor = false;
            this.Btn_cancelarp.Click += new System.EventHandler(this.Btn_cancelarp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Marco de trabajo";
            // 
            // Txt_Descripción
            // 
            this.Txt_Descripción.Location = new System.Drawing.Point(461, 55);
            this.Txt_Descripción.Multiline = true;
            this.Txt_Descripción.Name = "Txt_Descripción";
            this.Txt_Descripción.Size = new System.Drawing.Size(184, 172);
            this.Txt_Descripción.TabIndex = 29;
            // 
            // Cbo_tipoproceso
            // 
            this.Cbo_tipoproceso.FormattingEnabled = true;
            this.Cbo_tipoproceso.Location = new System.Drawing.Point(198, 106);
            this.Cbo_tipoproceso.Name = "Cbo_tipoproceso";
            this.Cbo_tipoproceso.Size = new System.Drawing.Size(240, 29);
            this.Cbo_tipoproceso.TabIndex = 28;
            this.Cbo_tipoproceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_tipoproceso_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo de Proceso";
            // 
            // Cbo_seleccionmarcop
            // 
            this.Cbo_seleccionmarcop.FormattingEnabled = true;
            this.Cbo_seleccionmarcop.Location = new System.Drawing.Point(198, 22);
            this.Cbo_seleccionmarcop.Name = "Cbo_seleccionmarcop";
            this.Cbo_seleccionmarcop.Size = new System.Drawing.Size(240, 29);
            this.Cbo_seleccionmarcop.TabIndex = 26;
            this.Cbo_seleccionmarcop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_tipoproceso_KeyPress);
            // 
            // Dgv_procesos
            // 
            this.Dgv_procesos.AllowUserToAddRows = false;
            this.Dgv_procesos.AllowUserToDeleteRows = false;
            this.Dgv_procesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_procesos.Location = new System.Drawing.Point(17, 255);
            this.Dgv_procesos.MultiSelect = false;
            this.Dgv_procesos.Name = "Dgv_procesos";
            this.Dgv_procesos.ReadOnly = true;
            this.Dgv_procesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_procesos.Size = new System.Drawing.Size(767, 166);
            this.Dgv_procesos.TabIndex = 25;
            this.Dgv_procesos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_procesos_CellDoubleClick);
            this.Dgv_procesos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_procesos_KeyDown);
            this.Dgv_procesos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dgv_procesos_KeyUp);
            // 
            // Btn_nuevop
            // 
            this.Btn_nuevop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevop.FlatAppearance.BorderSize = 0;
            this.Btn_nuevop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_nuevop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevop.Location = new System.Drawing.Point(673, 205);
            this.Btn_nuevop.Name = "Btn_nuevop";
            this.Btn_nuevop.Size = new System.Drawing.Size(111, 38);
            this.Btn_nuevop.TabIndex = 24;
            this.Btn_nuevop.Text = "Nuevo";
            this.Btn_nuevop.UseVisualStyleBackColor = false;
            this.Btn_nuevop.Click += new System.EventHandler(this.Btn_nuevop_Click);
            // 
            // Btn_eliminarp
            // 
            this.Btn_eliminarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminarp.FlatAppearance.BorderSize = 0;
            this.Btn_eliminarp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_eliminarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminarp.Location = new System.Drawing.Point(673, 117);
            this.Btn_eliminarp.Name = "Btn_eliminarp";
            this.Btn_eliminarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_eliminarp.TabIndex = 23;
            this.Btn_eliminarp.Text = "Eliminar";
            this.Btn_eliminarp.UseVisualStyleBackColor = false;
            this.Btn_eliminarp.Click += new System.EventHandler(this.Btn_eliminarp_Click);
            // 
            // Btn_modificarp
            // 
            this.Btn_modificarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificarp.FlatAppearance.BorderSize = 0;
            this.Btn_modificarp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_modificarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificarp.Location = new System.Drawing.Point(673, 69);
            this.Btn_modificarp.Name = "Btn_modificarp";
            this.Btn_modificarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_modificarp.TabIndex = 22;
            this.Btn_modificarp.Text = "Modificar";
            this.Btn_modificarp.UseVisualStyleBackColor = false;
            this.Btn_modificarp.Click += new System.EventHandler(this.Btn_modificarp_Click);
            // 
            // Btn_agregarp
            // 
            this.Btn_agregarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregarp.FlatAppearance.BorderSize = 0;
            this.Btn_agregarp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_agregarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarp.Location = new System.Drawing.Point(673, 22);
            this.Btn_agregarp.Name = "Btn_agregarp";
            this.Btn_agregarp.Size = new System.Drawing.Size(111, 38);
            this.Btn_agregarp.TabIndex = 21;
            this.Btn_agregarp.Text = "Agregar";
            this.Btn_agregarp.UseVisualStyleBackColor = false;
            this.Btn_agregarp.Click += new System.EventHandler(this.Btn_agregarp_Click);
            // 
            // Cbo_estadoproceso
            // 
            this.Cbo_estadoproceso.FormattingEnabled = true;
            this.Cbo_estadoproceso.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estadoproceso.Location = new System.Drawing.Point(198, 198);
            this.Cbo_estadoproceso.Name = "Cbo_estadoproceso";
            this.Cbo_estadoproceso.Size = new System.Drawing.Size(240, 29);
            this.Cbo_estadoproceso.TabIndex = 20;
            this.Cbo_estadoproceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_tipoproceso_KeyPress);
            // 
            // Txt_nombreproceso
            // 
            this.Txt_nombreproceso.Location = new System.Drawing.Point(198, 150);
            this.Txt_nombreproceso.Name = "Txt_nombreproceso";
            this.Txt_nombreproceso.Size = new System.Drawing.Size(240, 27);
            this.Txt_nombreproceso.TabIndex = 19;
            // 
            // Txt_codigoproceso
            // 
            this.Txt_codigoproceso.Location = new System.Drawing.Point(198, 69);
            this.Txt_codigoproceso.Name = "Txt_codigoproceso";
            this.Txt_codigoproceso.Size = new System.Drawing.Size(240, 27);
            this.Txt_codigoproceso.TabIndex = 18;
            // 
            // Lbl_estadoproceso
            // 
            this.Lbl_estadoproceso.AutoSize = true;
            this.Lbl_estadoproceso.Location = new System.Drawing.Point(108, 198);
            this.Lbl_estadoproceso.Name = "Lbl_estadoproceso";
            this.Lbl_estadoproceso.Size = new System.Drawing.Size(64, 21);
            this.Lbl_estadoproceso.TabIndex = 16;
            this.Lbl_estadoproceso.Text = "Estado";
            // 
            // Lbl_nombreproceso
            // 
            this.Lbl_nombreproceso.AutoSize = true;
            this.Lbl_nombreproceso.Location = new System.Drawing.Point(16, 150);
            this.Lbl_nombreproceso.Name = "Lbl_nombreproceso";
            this.Lbl_nombreproceso.Size = new System.Drawing.Size(165, 21);
            this.Lbl_nombreproceso.TabIndex = 15;
            this.Lbl_nombreproceso.Text = "Nombre del Proceso";
            // 
            // Lbl_codigoproceso
            // 
            this.Lbl_codigoproceso.AutoSize = true;
            this.Lbl_codigoproceso.Location = new System.Drawing.Point(21, 72);
            this.Lbl_codigoproceso.Name = "Lbl_codigoproceso";
            this.Lbl_codigoproceso.Size = new System.Drawing.Size(160, 21);
            this.Lbl_codigoproceso.TabIndex = 14;
            this.Lbl_codigoproceso.Text = "Código del Proceso";
            // 
            // Lbl_seleccionemarcop
            // 
            this.Lbl_seleccionemarcop.AutoSize = true;
            this.Lbl_seleccionemarcop.Location = new System.Drawing.Point(457, 22);
            this.Lbl_seleccionemarcop.Name = "Lbl_seleccionemarcop";
            this.Lbl_seleccionemarcop.Size = new System.Drawing.Size(100, 21);
            this.Lbl_seleccionemarcop.TabIndex = 13;
            this.Lbl_seleccionemarcop.Text = "Descripción";
            // 
            // Tbp_objetivos
            // 
            this.Tbp_objetivos.Controls.Add(this.Btn_cancelaro);
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
            // Btn_cancelaro
            // 
            this.Btn_cancelaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_cancelaro.FlatAppearance.BorderSize = 0;
            this.Btn_cancelaro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_cancelaro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_cancelaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelaro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelaro.Location = new System.Drawing.Point(673, 150);
            this.Btn_cancelaro.Name = "Btn_cancelaro";
            this.Btn_cancelaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_cancelaro.TabIndex = 39;
            this.Btn_cancelaro.Text = "Cancelar";
            this.Btn_cancelaro.UseVisualStyleBackColor = false;
            this.Btn_cancelaro.Click += new System.EventHandler(this.Btn_cancelaro_Click);
            // 
            // Txt_descripcionobjetivo
            // 
            this.Txt_descripcionobjetivo.Location = new System.Drawing.Point(453, 42);
            this.Txt_descripcionobjetivo.Multiline = true;
            this.Txt_descripcionobjetivo.Name = "Txt_descripcionobjetivo";
            this.Txt_descripcionobjetivo.Size = new System.Drawing.Size(192, 192);
            this.Txt_descripcionobjetivo.TabIndex = 38;
            // 
            // Lbl_descripcionobjetivo
            // 
            this.Lbl_descripcionobjetivo.AutoSize = true;
            this.Lbl_descripcionobjetivo.Location = new System.Drawing.Point(449, 18);
            this.Lbl_descripcionobjetivo.Name = "Lbl_descripcionobjetivo";
            this.Lbl_descripcionobjetivo.Size = new System.Drawing.Size(100, 21);
            this.Lbl_descripcionobjetivo.TabIndex = 37;
            this.Lbl_descripcionobjetivo.Text = "Descripción";
            // 
            // Cbo_proceso
            // 
            this.Cbo_proceso.FormattingEnabled = true;
            this.Cbo_proceso.Location = new System.Drawing.Point(188, 68);
            this.Cbo_proceso.Name = "Cbo_proceso";
            this.Cbo_proceso.Size = new System.Drawing.Size(240, 29);
            this.Cbo_proceso.TabIndex = 36;
            this.Cbo_proceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_seleccionemarcoo_KeyPress);
            // 
            // Lbl_seleccioneproceso
            // 
            this.Lbl_seleccioneproceso.AutoSize = true;
            this.Lbl_seleccioneproceso.Location = new System.Drawing.Point(108, 71);
            this.Lbl_seleccioneproceso.Name = "Lbl_seleccioneproceso";
            this.Lbl_seleccioneproceso.Size = new System.Drawing.Size(74, 21);
            this.Lbl_seleccioneproceso.TabIndex = 35;
            this.Lbl_seleccioneproceso.Text = " Proceso";
            // 
            // Cbo_seleccionemarcoo
            // 
            this.Cbo_seleccionemarcoo.FormattingEnabled = true;
            this.Cbo_seleccionemarcoo.Location = new System.Drawing.Point(188, 15);
            this.Cbo_seleccionemarcoo.Name = "Cbo_seleccionemarcoo";
            this.Cbo_seleccionemarcoo.Size = new System.Drawing.Size(240, 29);
            this.Cbo_seleccionemarcoo.TabIndex = 34;
            this.Cbo_seleccionemarcoo.SelectedIndexChanged += new System.EventHandler(this.Cbo_seleccionemarcoo_SelectedIndexChanged);
            this.Cbo_seleccionemarcoo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_seleccionemarcoo_KeyPress);
            // 
            // Cbo_estadoobjetivo
            // 
            this.Cbo_estadoobjetivo.FormattingEnabled = true;
            this.Cbo_estadoobjetivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estadoobjetivo.Location = new System.Drawing.Point(186, 205);
            this.Cbo_estadoobjetivo.Name = "Cbo_estadoobjetivo";
            this.Cbo_estadoobjetivo.Size = new System.Drawing.Size(240, 29);
            this.Cbo_estadoobjetivo.TabIndex = 33;
            this.Cbo_estadoobjetivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_seleccionemarcoo_KeyPress);
            // 
            // Txt_nombreobjetivo
            // 
            this.Txt_nombreobjetivo.Location = new System.Drawing.Point(186, 161);
            this.Txt_nombreobjetivo.Name = "Txt_nombreobjetivo";
            this.Txt_nombreobjetivo.Size = new System.Drawing.Size(240, 27);
            this.Txt_nombreobjetivo.TabIndex = 32;
            // 
            // Txt_codigoobjetivo
            // 
            this.Txt_codigoobjetivo.Location = new System.Drawing.Point(186, 116);
            this.Txt_codigoobjetivo.Name = "Txt_codigoobjetivo";
            this.Txt_codigoobjetivo.Size = new System.Drawing.Size(240, 27);
            this.Txt_codigoobjetivo.TabIndex = 31;
            // 
            // Lbl_estadoobjetivo
            // 
            this.Lbl_estadoobjetivo.AutoSize = true;
            this.Lbl_estadoobjetivo.Location = new System.Drawing.Point(116, 205);
            this.Lbl_estadoobjetivo.Name = "Lbl_estadoobjetivo";
            this.Lbl_estadoobjetivo.Size = new System.Drawing.Size(64, 21);
            this.Lbl_estadoobjetivo.TabIndex = 30;
            this.Lbl_estadoobjetivo.Text = "Estado";
            // 
            // Lbl_nombreobjetivo
            // 
            this.Lbl_nombreobjetivo.AutoSize = true;
            this.Lbl_nombreobjetivo.Location = new System.Drawing.Point(9, 161);
            this.Lbl_nombreobjetivo.Name = "Lbl_nombreobjetivo";
            this.Lbl_nombreobjetivo.Size = new System.Drawing.Size(173, 21);
            this.Lbl_nombreobjetivo.TabIndex = 29;
            this.Lbl_nombreobjetivo.Text = "Nombre del Objetivo";
            // 
            // Lbl_codigoobjetivo
            // 
            this.Lbl_codigoobjetivo.AutoSize = true;
            this.Lbl_codigoobjetivo.Location = new System.Drawing.Point(16, 116);
            this.Lbl_codigoobjetivo.Name = "Lbl_codigoobjetivo";
            this.Lbl_codigoobjetivo.Size = new System.Drawing.Size(168, 21);
            this.Lbl_codigoobjetivo.TabIndex = 28;
            this.Lbl_codigoobjetivo.Text = "Código del Objetivo";
            // 
            // Lbl_seleccionemarcoo
            // 
            this.Lbl_seleccionemarcoo.AutoSize = true;
            this.Lbl_seleccionemarcoo.Location = new System.Drawing.Point(33, 23);
            this.Lbl_seleccionemarcoo.Name = "Lbl_seleccionemarcoo";
            this.Lbl_seleccionemarcoo.Size = new System.Drawing.Size(149, 21);
            this.Lbl_seleccionemarcoo.TabIndex = 27;
            this.Lbl_seleccionemarcoo.Text = "Marco de Trabajo";
            // 
            // Dgv_objetivos
            // 
            this.Dgv_objetivos.AllowUserToAddRows = false;
            this.Dgv_objetivos.AllowUserToDeleteRows = false;
            this.Dgv_objetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_objetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_objetivos.Location = new System.Drawing.Point(17, 255);
            this.Dgv_objetivos.MultiSelect = false;
            this.Dgv_objetivos.Name = "Dgv_objetivos";
            this.Dgv_objetivos.ReadOnly = true;
            this.Dgv_objetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_objetivos.Size = new System.Drawing.Size(767, 166);
            this.Dgv_objetivos.TabIndex = 25;
            this.Dgv_objetivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_objetivos_CellDoubleClick);
            this.Dgv_objetivos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_objetivos_KeyDown);
            this.Dgv_objetivos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dgv_objetivos_KeyUp);
            // 
            // Btn_nuevoo
            // 
            this.Btn_nuevoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevoo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevoo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevoo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_nuevoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevoo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevoo.Location = new System.Drawing.Point(673, 196);
            this.Btn_nuevoo.Name = "Btn_nuevoo";
            this.Btn_nuevoo.Size = new System.Drawing.Size(111, 38);
            this.Btn_nuevoo.TabIndex = 24;
            this.Btn_nuevoo.Text = "Nuevo";
            this.Btn_nuevoo.UseVisualStyleBackColor = false;
            this.Btn_nuevoo.Click += new System.EventHandler(this.Btn_nuevoo_Click);
            // 
            // Btn_eliminaro
            // 
            this.Btn_eliminaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminaro.FlatAppearance.BorderSize = 0;
            this.Btn_eliminaro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminaro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_eliminaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminaro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminaro.Location = new System.Drawing.Point(673, 106);
            this.Btn_eliminaro.Name = "Btn_eliminaro";
            this.Btn_eliminaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_eliminaro.TabIndex = 23;
            this.Btn_eliminaro.Text = "Eliminar";
            this.Btn_eliminaro.UseVisualStyleBackColor = false;
            this.Btn_eliminaro.Click += new System.EventHandler(this.Btn_eliminaro_Click);
            // 
            // Btn_modificaro
            // 
            this.Btn_modificaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificaro.FlatAppearance.BorderSize = 0;
            this.Btn_modificaro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificaro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_modificaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificaro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificaro.Location = new System.Drawing.Point(673, 58);
            this.Btn_modificaro.Name = "Btn_modificaro";
            this.Btn_modificaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_modificaro.TabIndex = 22;
            this.Btn_modificaro.Text = "Modificar";
            this.Btn_modificaro.UseVisualStyleBackColor = false;
            this.Btn_modificaro.Click += new System.EventHandler(this.Btn_modificaro_Click);
            // 
            // Btn_agregaro
            // 
            this.Btn_agregaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregaro.FlatAppearance.BorderSize = 0;
            this.Btn_agregaro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregaro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_agregaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregaro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregaro.Location = new System.Drawing.Point(673, 14);
            this.Btn_agregaro.Name = "Btn_agregaro";
            this.Btn_agregaro.Size = new System.Drawing.Size(111, 38);
            this.Btn_agregaro.TabIndex = 21;
            this.Btn_agregaro.Text = "Agregar";
            this.Btn_agregaro.UseVisualStyleBackColor = false;
            this.Btn_agregaro.Click += new System.EventHandler(this.Btn_agregaro_Click);
            // 
            // Pnl_marcosdetrabajo
            // 
            this.Pnl_marcosdetrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Pnl_marcosdetrabajo.Controls.Add(this.pictureBox1);
            this.Pnl_marcosdetrabajo.Controls.Add(this.Lbl_titulo);
            this.Pnl_marcosdetrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_marcosdetrabajo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_marcosdetrabajo.Name = "Pnl_marcosdetrabajo";
            this.Pnl_marcosdetrabajo.Size = new System.Drawing.Size(882, 55);
            this.Pnl_marcosdetrabajo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Marcos de Trabajo";
            this.Load += new System.EventHandler(this.Frm_registrarmarco_Load);
            this.Tbc_gestionmarcos.ResumeLayout(false);
            this.Tbp_procesos.ResumeLayout(false);
            this.Tbp_procesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_procesos)).EndInit();
            this.Tbp_objetivos.ResumeLayout(false);
            this.Tbp_objetivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_objetivos)).EndInit();
            this.Pnl_marcosdetrabajo.ResumeLayout(false);
            this.Pnl_marcosdetrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TabControl Tbc_gestionmarcos;
        private System.Windows.Forms.TabPage Tbp_procesos;
        private System.Windows.Forms.TabPage Tbp_objetivos;
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
		private System.Windows.Forms.ComboBox Cbo_tipoproceso;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Txt_Descripción;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Btn_cancelarp;
		private System.Windows.Forms.Button Btn_cancelaro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}