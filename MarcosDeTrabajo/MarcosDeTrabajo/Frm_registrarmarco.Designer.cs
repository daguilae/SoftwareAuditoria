namespace MarcosDeTrabajo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tbc_gestionmarcos = new System.Windows.Forms.TabControl();
            this.Tbp_marcosdetrabajo = new System.Windows.Forms.TabPage();
            this.Tbp_procesos = new System.Windows.Forms.TabPage();
            this.Tbp_objetivos = new System.Windows.Forms.TabPage();
            this.Lbl_codigomarco = new System.Windows.Forms.Label();
            this.Lbl_nombremarco = new System.Windows.Forms.Label();
            this.Lbl_descripcionmarco = new System.Windows.Forms.Label();
            this.Lbl_estadomarco = new System.Windows.Forms.Label();
            this.Txt_codigomarco = new System.Windows.Forms.TextBox();
            this.Txt_nombremarco = new System.Windows.Forms.TextBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Cbo_estadomarco = new System.Windows.Forms.ComboBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Dgv_marcosdetrabajo = new System.Windows.Forms.DataGridView();
            this.Dgv_procesos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Cbo_estadoproceso = new System.Windows.Forms.ComboBox();
            this.Txt_nombreproceso = new System.Windows.Forms.TextBox();
            this.Txt_codigoproceso = new System.Windows.Forms.TextBox();
            this.Lbl_estadoproceso = new System.Windows.Forms.Label();
            this.Lbl_nombreproceso = new System.Windows.Forms.Label();
            this.Lbl_codigoproceso = new System.Windows.Forms.Label();
            this.Lbl_seleccionemarcop = new System.Windows.Forms.Label();
            this.Dgv_objetivos = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Cbo_seleccionmarcop = new System.Windows.Forms.ComboBox();
            this.Cbo_seleccionemarcoo = new System.Windows.Forms.ComboBox();
            this.Cbo_estadoobjetivo = new System.Windows.Forms.ComboBox();
            this.Txt_nombreobjetivo = new System.Windows.Forms.TextBox();
            this.Txt_codigoobjetivo = new System.Windows.Forms.TextBox();
            this.Lbl_estadoobjetivo = new System.Windows.Forms.Label();
            this.Lbl_nombreobjetivo = new System.Windows.Forms.Label();
            this.Lbl_codigoobjetivo = new System.Windows.Forms.Label();
            this.Lbl_seleccionemarcoo = new System.Windows.Forms.Label();
            this.Cbo_proceso = new System.Windows.Forms.ComboBox();
            this.Lbl_seleccioneproceso = new System.Windows.Forms.Label();
            this.Txt_descripcionobjetivo = new System.Windows.Forms.TextBox();
            this.Lbl_descripcionobjetivo = new System.Windows.Forms.Label();
            this.Pnl_marcosdetrabajo = new System.Windows.Forms.Panel();
            this.Tbc_gestionmarcos.SuspendLayout();
            this.Tbp_marcosdetrabajo.SuspendLayout();
            this.Tbp_procesos.SuspendLayout();
            this.Tbp_objetivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_marcosdetrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_procesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_objetivos)).BeginInit();
            this.Pnl_marcosdetrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión Marcos de Trabajo";
            // 
            // Tbc_gestionmarcos
            // 
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_marcosdetrabajo);
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_procesos);
            this.Tbc_gestionmarcos.Controls.Add(this.Tbp_objetivos);
            this.Tbc_gestionmarcos.Location = new System.Drawing.Point(26, 73);
            this.Tbc_gestionmarcos.Name = "Tbc_gestionmarcos";
            this.Tbc_gestionmarcos.SelectedIndex = 0;
            this.Tbc_gestionmarcos.Size = new System.Drawing.Size(730, 425);
            this.Tbc_gestionmarcos.TabIndex = 1;
            // 
            // Tbp_marcosdetrabajo
            // 
            this.Tbp_marcosdetrabajo.Controls.Add(this.Dgv_marcosdetrabajo);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_nuevo);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_eliminar);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_modificar);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Btn_agregar);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Cbo_estadomarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Txt_descripcion);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Txt_nombremarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Txt_codigomarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_estadomarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_descripcionmarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_nombremarco);
            this.Tbp_marcosdetrabajo.Controls.Add(this.Lbl_codigomarco);
            this.Tbp_marcosdetrabajo.Location = new System.Drawing.Point(4, 28);
            this.Tbp_marcosdetrabajo.Name = "Tbp_marcosdetrabajo";
            this.Tbp_marcosdetrabajo.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_marcosdetrabajo.Size = new System.Drawing.Size(722, 393);
            this.Tbp_marcosdetrabajo.TabIndex = 0;
            this.Tbp_marcosdetrabajo.Text = "Marcos de Trabajo";
            this.Tbp_marcosdetrabajo.UseVisualStyleBackColor = true;
            // 
            // Tbp_procesos
            // 
            this.Tbp_procesos.Controls.Add(this.Cbo_seleccionmarcop);
            this.Tbp_procesos.Controls.Add(this.Dgv_procesos);
            this.Tbp_procesos.Controls.Add(this.button1);
            this.Tbp_procesos.Controls.Add(this.button2);
            this.Tbp_procesos.Controls.Add(this.button3);
            this.Tbp_procesos.Controls.Add(this.button4);
            this.Tbp_procesos.Controls.Add(this.Cbo_estadoproceso);
            this.Tbp_procesos.Controls.Add(this.Txt_nombreproceso);
            this.Tbp_procesos.Controls.Add(this.Txt_codigoproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_estadoproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_nombreproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_codigoproceso);
            this.Tbp_procesos.Controls.Add(this.Lbl_seleccionemarcop);
            this.Tbp_procesos.Location = new System.Drawing.Point(4, 28);
            this.Tbp_procesos.Name = "Tbp_procesos";
            this.Tbp_procesos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_procesos.Size = new System.Drawing.Size(722, 393);
            this.Tbp_procesos.TabIndex = 1;
            this.Tbp_procesos.Text = "Procesos";
            this.Tbp_procesos.UseVisualStyleBackColor = true;
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
            this.Tbp_objetivos.Controls.Add(this.button5);
            this.Tbp_objetivos.Controls.Add(this.button6);
            this.Tbp_objetivos.Controls.Add(this.button7);
            this.Tbp_objetivos.Controls.Add(this.button8);
            this.Tbp_objetivos.Location = new System.Drawing.Point(4, 28);
            this.Tbp_objetivos.Name = "Tbp_objetivos";
            this.Tbp_objetivos.Size = new System.Drawing.Size(722, 393);
            this.Tbp_objetivos.TabIndex = 2;
            this.Tbp_objetivos.Text = "Objetivos";
            this.Tbp_objetivos.UseVisualStyleBackColor = true;
            this.Tbp_objetivos.Click += new System.EventHandler(this.Tbp_objetivos_Click);
            // 
            // Lbl_codigomarco
            // 
            this.Lbl_codigomarco.AutoSize = true;
            this.Lbl_codigomarco.Location = new System.Drawing.Point(163, 25);
            this.Lbl_codigomarco.Name = "Lbl_codigomarco";
            this.Lbl_codigomarco.Size = new System.Drawing.Size(54, 19);
            this.Lbl_codigomarco.TabIndex = 0;
            this.Lbl_codigomarco.Text = "Código";
            this.Lbl_codigomarco.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_nombremarco
            // 
            this.Lbl_nombremarco.AutoSize = true;
            this.Lbl_nombremarco.Location = new System.Drawing.Point(90, 61);
            this.Lbl_nombremarco.Name = "Lbl_nombremarco";
            this.Lbl_nombremarco.Size = new System.Drawing.Size(127, 19);
            this.Lbl_nombremarco.TabIndex = 1;
            this.Lbl_nombremarco.Text = "Nombre del Marco";
            this.Lbl_nombremarco.Click += new System.EventHandler(this.Lbl_nombremarco_Click);
            // 
            // Lbl_descripcionmarco
            // 
            this.Lbl_descripcionmarco.AutoSize = true;
            this.Lbl_descripcionmarco.Location = new System.Drawing.Point(136, 103);
            this.Lbl_descripcionmarco.Name = "Lbl_descripcionmarco";
            this.Lbl_descripcionmarco.Size = new System.Drawing.Size(81, 19);
            this.Lbl_descripcionmarco.TabIndex = 2;
            this.Lbl_descripcionmarco.Text = "Descripción";
            // 
            // Lbl_estadomarco
            // 
            this.Lbl_estadomarco.AutoSize = true;
            this.Lbl_estadomarco.Location = new System.Drawing.Point(163, 184);
            this.Lbl_estadomarco.Name = "Lbl_estadomarco";
            this.Lbl_estadomarco.Size = new System.Drawing.Size(51, 19);
            this.Lbl_estadomarco.TabIndex = 3;
            this.Lbl_estadomarco.Text = "Estado";
            // 
            // Txt_codigomarco
            // 
            this.Txt_codigomarco.Location = new System.Drawing.Point(223, 25);
            this.Txt_codigomarco.Name = "Txt_codigomarco";
            this.Txt_codigomarco.Size = new System.Drawing.Size(216, 26);
            this.Txt_codigomarco.TabIndex = 4;
            // 
            // Txt_nombremarco
            // 
            this.Txt_nombremarco.Location = new System.Drawing.Point(223, 61);
            this.Txt_nombremarco.Name = "Txt_nombremarco";
            this.Txt_nombremarco.Size = new System.Drawing.Size(216, 26);
            this.Txt_nombremarco.TabIndex = 5;
            this.Txt_nombremarco.TextChanged += new System.EventHandler(this.Txt_nombremarco_TextChanged);
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(223, 98);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(216, 75);
            this.Txt_descripcion.TabIndex = 6;
            // 
            // Cbo_estadomarco
            // 
            this.Cbo_estadomarco.FormattingEnabled = true;
            this.Cbo_estadomarco.Location = new System.Drawing.Point(223, 184);
            this.Cbo_estadomarco.Name = "Cbo_estadomarco";
            this.Cbo_estadomarco.Size = new System.Drawing.Size(216, 27);
            this.Cbo_estadomarco.TabIndex = 7;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregar.Location = new System.Drawing.Point(503, 25);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(100, 34);
            this.Btn_agregar.TabIndex = 8;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_modificar.ForeColor = System.Drawing.Color.Black;
            this.Btn_modificar.Location = new System.Drawing.Point(503, 65);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(100, 34);
            this.Btn_modificar.TabIndex = 9;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminar.Location = new System.Drawing.Point(503, 108);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(100, 34);
            this.Btn_eliminar.TabIndex = 10;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_nuevo.ForeColor = System.Drawing.Color.Black;
            this.Btn_nuevo.Location = new System.Drawing.Point(503, 148);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(100, 34);
            this.Btn_nuevo.TabIndex = 11;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Dgv_marcosdetrabajo
            // 
            this.Dgv_marcosdetrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_marcosdetrabajo.Location = new System.Drawing.Point(15, 231);
            this.Dgv_marcosdetrabajo.Name = "Dgv_marcosdetrabajo";
            this.Dgv_marcosdetrabajo.Size = new System.Drawing.Size(690, 150);
            this.Dgv_marcosdetrabajo.TabIndex = 12;
            // 
            // Dgv_procesos
            // 
            this.Dgv_procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_procesos.Location = new System.Drawing.Point(15, 231);
            this.Dgv_procesos.Name = "Dgv_procesos";
            this.Dgv_procesos.Size = new System.Drawing.Size(690, 150);
            this.Dgv_procesos.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(504, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(504, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 22;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(504, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Cbo_estadoproceso
            // 
            this.Cbo_estadoproceso.FormattingEnabled = true;
            this.Cbo_estadoproceso.Location = new System.Drawing.Point(223, 160);
            this.Cbo_estadoproceso.Name = "Cbo_estadoproceso";
            this.Cbo_estadoproceso.Size = new System.Drawing.Size(216, 27);
            this.Cbo_estadoproceso.TabIndex = 20;
            // 
            // Txt_nombreproceso
            // 
            this.Txt_nombreproceso.Location = new System.Drawing.Point(223, 114);
            this.Txt_nombreproceso.Name = "Txt_nombreproceso";
            this.Txt_nombreproceso.Size = new System.Drawing.Size(216, 26);
            this.Txt_nombreproceso.TabIndex = 19;
            // 
            // Txt_codigoproceso
            // 
            this.Txt_codigoproceso.Location = new System.Drawing.Point(223, 71);
            this.Txt_codigoproceso.Name = "Txt_codigoproceso";
            this.Txt_codigoproceso.Size = new System.Drawing.Size(216, 26);
            this.Txt_codigoproceso.TabIndex = 18;
            // 
            // Lbl_estadoproceso
            // 
            this.Lbl_estadoproceso.AutoSize = true;
            this.Lbl_estadoproceso.Location = new System.Drawing.Point(166, 160);
            this.Lbl_estadoproceso.Name = "Lbl_estadoproceso";
            this.Lbl_estadoproceso.Size = new System.Drawing.Size(51, 19);
            this.Lbl_estadoproceso.TabIndex = 16;
            this.Lbl_estadoproceso.Text = "Estado";
            // 
            // Lbl_nombreproceso
            // 
            this.Lbl_nombreproceso.AutoSize = true;
            this.Lbl_nombreproceso.Location = new System.Drawing.Point(81, 114);
            this.Lbl_nombreproceso.Name = "Lbl_nombreproceso";
            this.Lbl_nombreproceso.Size = new System.Drawing.Size(136, 19);
            this.Lbl_nombreproceso.TabIndex = 15;
            this.Lbl_nombreproceso.Text = "Nombre del Proceso";
            // 
            // Lbl_codigoproceso
            // 
            this.Lbl_codigoproceso.AutoSize = true;
            this.Lbl_codigoproceso.Location = new System.Drawing.Point(87, 71);
            this.Lbl_codigoproceso.Name = "Lbl_codigoproceso";
            this.Lbl_codigoproceso.Size = new System.Drawing.Size(130, 19);
            this.Lbl_codigoproceso.TabIndex = 14;
            this.Lbl_codigoproceso.Text = "Código del Proceso";
            // 
            // Lbl_seleccionemarcop
            // 
            this.Lbl_seleccionemarcop.AutoSize = true;
            this.Lbl_seleccionemarcop.Location = new System.Drawing.Point(28, 28);
            this.Lbl_seleccionemarcop.Name = "Lbl_seleccionemarcop";
            this.Lbl_seleccionemarcop.Size = new System.Drawing.Size(189, 19);
            this.Lbl_seleccionemarcop.TabIndex = 13;
            this.Lbl_seleccionemarcop.Text = "Seleccione Marco de Trabajo";
            // 
            // Dgv_objetivos
            // 
            this.Dgv_objetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_objetivos.Location = new System.Drawing.Point(15, 231);
            this.Dgv_objetivos.Name = "Dgv_objetivos";
            this.Dgv_objetivos.Size = new System.Drawing.Size(690, 150);
            this.Dgv_objetivos.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button5.Location = new System.Drawing.Point(504, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 24;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button6.Location = new System.Drawing.Point(504, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 34);
            this.button6.TabIndex = 23;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button7.Location = new System.Drawing.Point(504, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 34);
            this.button7.TabIndex = 22;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button8.Location = new System.Drawing.Point(504, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 34);
            this.button8.TabIndex = 21;
            this.button8.Text = "Agregar";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Cbo_seleccionmarcop
            // 
            this.Cbo_seleccionmarcop.FormattingEnabled = true;
            this.Cbo_seleccionmarcop.Location = new System.Drawing.Point(223, 28);
            this.Cbo_seleccionmarcop.Name = "Cbo_seleccionmarcop";
            this.Cbo_seleccionmarcop.Size = new System.Drawing.Size(216, 27);
            this.Cbo_seleccionmarcop.TabIndex = 26;
            // 
            // Cbo_seleccionemarcoo
            // 
            this.Cbo_seleccionemarcoo.FormattingEnabled = true;
            this.Cbo_seleccionemarcoo.Location = new System.Drawing.Point(223, 10);
            this.Cbo_seleccionemarcoo.Name = "Cbo_seleccionemarcoo";
            this.Cbo_seleccionemarcoo.Size = new System.Drawing.Size(216, 27);
            this.Cbo_seleccionemarcoo.TabIndex = 34;
            // 
            // Cbo_estadoobjetivo
            // 
            this.Cbo_estadoobjetivo.FormattingEnabled = true;
            this.Cbo_estadoobjetivo.Location = new System.Drawing.Point(223, 194);
            this.Cbo_estadoobjetivo.Name = "Cbo_estadoobjetivo";
            this.Cbo_estadoobjetivo.Size = new System.Drawing.Size(216, 27);
            this.Cbo_estadoobjetivo.TabIndex = 33;
            // 
            // Txt_nombreobjetivo
            // 
            this.Txt_nombreobjetivo.Location = new System.Drawing.Point(223, 110);
            this.Txt_nombreobjetivo.Name = "Txt_nombreobjetivo";
            this.Txt_nombreobjetivo.Size = new System.Drawing.Size(216, 26);
            this.Txt_nombreobjetivo.TabIndex = 32;
            // 
            // Txt_codigoobjetivo
            // 
            this.Txt_codigoobjetivo.Location = new System.Drawing.Point(223, 77);
            this.Txt_codigoobjetivo.Name = "Txt_codigoobjetivo";
            this.Txt_codigoobjetivo.Size = new System.Drawing.Size(216, 26);
            this.Txt_codigoobjetivo.TabIndex = 31;
            // 
            // Lbl_estadoobjetivo
            // 
            this.Lbl_estadoobjetivo.AutoSize = true;
            this.Lbl_estadoobjetivo.Location = new System.Drawing.Point(166, 194);
            this.Lbl_estadoobjetivo.Name = "Lbl_estadoobjetivo";
            this.Lbl_estadoobjetivo.Size = new System.Drawing.Size(51, 19);
            this.Lbl_estadoobjetivo.TabIndex = 30;
            this.Lbl_estadoobjetivo.Text = "Estado";
            // 
            // Lbl_nombreobjetivo
            // 
            this.Lbl_nombreobjetivo.AutoSize = true;
            this.Lbl_nombreobjetivo.Location = new System.Drawing.Point(81, 110);
            this.Lbl_nombreobjetivo.Name = "Lbl_nombreobjetivo";
            this.Lbl_nombreobjetivo.Size = new System.Drawing.Size(139, 19);
            this.Lbl_nombreobjetivo.TabIndex = 29;
            this.Lbl_nombreobjetivo.Text = "Nombre del Objetivo";
            // 
            // Lbl_codigoobjetivo
            // 
            this.Lbl_codigoobjetivo.AutoSize = true;
            this.Lbl_codigoobjetivo.Location = new System.Drawing.Point(87, 77);
            this.Lbl_codigoobjetivo.Name = "Lbl_codigoobjetivo";
            this.Lbl_codigoobjetivo.Size = new System.Drawing.Size(133, 19);
            this.Lbl_codigoobjetivo.TabIndex = 28;
            this.Lbl_codigoobjetivo.Text = "Código del Objetivo";
            // 
            // Lbl_seleccionemarcoo
            // 
            this.Lbl_seleccionemarcoo.AutoSize = true;
            this.Lbl_seleccionemarcoo.Location = new System.Drawing.Point(28, 10);
            this.Lbl_seleccionemarcoo.Name = "Lbl_seleccionemarcoo";
            this.Lbl_seleccionemarcoo.Size = new System.Drawing.Size(189, 19);
            this.Lbl_seleccionemarcoo.TabIndex = 27;
            this.Lbl_seleccionemarcoo.Text = "Seleccione Marco de Trabajo";
            // 
            // Cbo_proceso
            // 
            this.Cbo_proceso.FormattingEnabled = true;
            this.Cbo_proceso.Location = new System.Drawing.Point(223, 43);
            this.Cbo_proceso.Name = "Cbo_proceso";
            this.Cbo_proceso.Size = new System.Drawing.Size(216, 27);
            this.Cbo_proceso.TabIndex = 36;
            // 
            // Lbl_seleccioneproceso
            // 
            this.Lbl_seleccioneproceso.AutoSize = true;
            this.Lbl_seleccioneproceso.Location = new System.Drawing.Point(71, 43);
            this.Lbl_seleccioneproceso.Name = "Lbl_seleccioneproceso";
            this.Lbl_seleccioneproceso.Size = new System.Drawing.Size(146, 19);
            this.Lbl_seleccioneproceso.TabIndex = 35;
            this.Lbl_seleccioneproceso.Text = "Seleccione un Proceso";
            // 
            // Txt_descripcionobjetivo
            // 
            this.Txt_descripcionobjetivo.Location = new System.Drawing.Point(223, 142);
            this.Txt_descripcionobjetivo.Multiline = true;
            this.Txt_descripcionobjetivo.Name = "Txt_descripcionobjetivo";
            this.Txt_descripcionobjetivo.Size = new System.Drawing.Size(216, 46);
            this.Txt_descripcionobjetivo.TabIndex = 38;
            // 
            // Lbl_descripcionobjetivo
            // 
            this.Lbl_descripcionobjetivo.AutoSize = true;
            this.Lbl_descripcionobjetivo.Location = new System.Drawing.Point(136, 142);
            this.Lbl_descripcionobjetivo.Name = "Lbl_descripcionobjetivo";
            this.Lbl_descripcionobjetivo.Size = new System.Drawing.Size(81, 19);
            this.Lbl_descripcionobjetivo.TabIndex = 37;
            this.Lbl_descripcionobjetivo.Text = "Descripción";
            // 
            // Pnl_marcosdetrabajo
            // 
            this.Pnl_marcosdetrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Pnl_marcosdetrabajo.Controls.Add(this.label1);
            this.Pnl_marcosdetrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_marcosdetrabajo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_marcosdetrabajo.Name = "Pnl_marcosdetrabajo";
            this.Pnl_marcosdetrabajo.Size = new System.Drawing.Size(794, 50);
            this.Pnl_marcosdetrabajo.TabIndex = 2;
            // 
            // Frm_registrarmarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 511);
            this.Controls.Add(this.Pnl_marcosdetrabajo);
            this.Controls.Add(this.Tbc_gestionmarcos);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_registrarmarco";
            this.Text = "Gestión Marcos de Trabajo";
            this.Tbc_gestionmarcos.ResumeLayout(false);
            this.Tbp_marcosdetrabajo.ResumeLayout(false);
            this.Tbp_marcosdetrabajo.PerformLayout();
            this.Tbp_procesos.ResumeLayout(false);
            this.Tbp_procesos.PerformLayout();
            this.Tbp_objetivos.ResumeLayout(false);
            this.Tbp_objetivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_marcosdetrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_procesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_objetivos)).EndInit();
            this.Pnl_marcosdetrabajo.ResumeLayout(false);
            this.Pnl_marcosdetrabajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.DataGridView Dgv_procesos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Cbo_estadoproceso;
        private System.Windows.Forms.TextBox Txt_nombreproceso;
        private System.Windows.Forms.TextBox Txt_codigoproceso;
        private System.Windows.Forms.Label Lbl_estadoproceso;
        private System.Windows.Forms.Label Lbl_nombreproceso;
        private System.Windows.Forms.Label Lbl_codigoproceso;
        private System.Windows.Forms.Label Lbl_seleccionemarcop;
        private System.Windows.Forms.DataGridView Dgv_objetivos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
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