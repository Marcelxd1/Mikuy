﻿namespace LP2Soft
{
    partial class frm_Clientes_Listar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes_Listar));
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvListarClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtApellidoMaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDNIRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDNIRuc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRazonSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.ldlRUC = new System.Windows.Forms.Label();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 10;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.FillColor = System.Drawing.Color.Black;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Location = new System.Drawing.Point(550, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.PressedColor = System.Drawing.Color.Blue;
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(119, 28);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(704, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedColor = System.Drawing.Color.Red;
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(107, 28);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.AllowUserToAddRows = false;
            this.dgvListarClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarClientes.ColumnHeadersHeight = 20;
            this.dgvListarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Tipo,
            this.DNIRUC,
            this.Username});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarClientes.EnableHeadersVisualStyles = false;
            this.dgvListarClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.Location = new System.Drawing.Point(25, 111);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.ReadOnly = true;
            this.dgvListarClientes.RowHeadersVisible = false;
            this.dgvListarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarClientes.Size = new System.Drawing.Size(786, 180);
            this.dgvListarClientes.TabIndex = 40;
            this.dgvListarClientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvListarClientes.ThemeStyle.ReadOnly = true;
            this.dgvListarClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListarClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListarClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListarClientes_CellFormatting);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "Buscar";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.Parent = this.txtBuscar;
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedState.Parent = this.txtBuscar;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.HoverState.Parent = this.txtBuscar;
            this.txtBuscar.IconRight = global::LP2Soft.Properties.Resources.Buscar;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.Location = new System.Drawing.Point(210, 72);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionStart = 6;
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(437, 30);
            this.txtBuscar.TabIndex = 39;
            this.txtBuscar.IconRightClick += new System.EventHandler(this.txtBuscar_IconRightClick);
            this.txtBuscar.DoubleClick += new System.EventHandler(this.txtBuscar_DoubleClick);
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.Color.White;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosUsuario.Location = new System.Drawing.Point(342, 28);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(183, 29);
            this.lblDatosUsuario.TabIndex = 37;
            this.lblDatosUsuario.Text = "Datos Clientes";
            this.lblDatosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(-1, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(834, 647);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 41;
            this.guna2PictureBox3.TabStop = false;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BorderColor = System.Drawing.Color.White;
            this.txtApellidoMaterno.BorderRadius = 10;
            this.txtApellidoMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoMaterno.DefaultText = "";
            this.txtApellidoMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.DisabledState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtApellidoMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.FocusedState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.HoverState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(498, 409);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.PasswordChar = '\0';
            this.txtApellidoMaterno.PlaceholderText = "";
            this.txtApellidoMaterno.SelectedText = "";
            this.txtApellidoMaterno.ShadowDecoration.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(203, 30);
            this.txtApellidoMaterno.TabIndex = 55;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(494, 381);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(153, 24);
            this.lblApellidoMaterno.TabIndex = 54;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BorderColor = System.Drawing.Color.White;
            this.txtApellidoPaterno.BorderRadius = 10;
            this.txtApellidoPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPaterno.DefaultText = "";
            this.txtApellidoPaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoPaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoPaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.DisabledState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtApellidoPaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.FocusedState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoPaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.HoverState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(249, 409);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.PasswordChar = '\0';
            this.txtApellidoPaterno.PlaceholderText = "";
            this.txtApellidoPaterno.SelectedText = "";
            this.txtApellidoPaterno.ShadowDecoration.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(203, 30);
            this.txtApellidoPaterno.TabIndex = 53;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(245, 381);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(149, 24);
            this.lblApellidoPaterno.TabIndex = 52;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(25, 409);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(203, 30);
            this.txtNombre.TabIndex = 51;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDNIRUC
            // 
            this.txtDNIRUC.BorderColor = System.Drawing.Color.White;
            this.txtDNIRUC.BorderRadius = 10;
            this.txtDNIRUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNIRUC.DefaultText = "";
            this.txtDNIRUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNIRUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNIRUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIRUC.DisabledState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIRUC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtDNIRUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIRUC.FocusedState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIRUC.ForeColor = System.Drawing.Color.Black;
            this.txtDNIRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIRUC.HoverState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Location = new System.Drawing.Point(25, 471);
            this.txtDNIRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNIRUC.Name = "txtDNIRUC";
            this.txtDNIRUC.PasswordChar = '\0';
            this.txtDNIRUC.PlaceholderText = "";
            this.txtDNIRUC.SelectedText = "";
            this.txtDNIRUC.ShadowDecoration.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Size = new System.Drawing.Size(203, 30);
            this.txtDNIRUC.TabIndex = 50;
            this.txtDNIRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIRUC_KeyPress);
            // 
            // lblDNIRuc
            // 
            this.lblDNIRuc.AutoSize = true;
            this.lblDNIRuc.BackColor = System.Drawing.SystemColors.Window;
            this.lblDNIRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIRuc.Location = new System.Drawing.Point(21, 443);
            this.lblDNIRuc.Name = "lblDNIRuc";
            this.lblDNIRuc.Size = new System.Drawing.Size(41, 24);
            this.lblDNIRuc.TabIndex = 49;
            this.lblDNIRuc.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 381);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderColor = System.Drawing.Color.White;
            this.txtRazonSocial.BorderRadius = 10;
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazonSocial.DefaultText = "";
            this.txtRazonSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRazonSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRazonSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazonSocial.DisabledState.Parent = this.txtRazonSocial;
            this.txtRazonSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazonSocial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtRazonSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazonSocial.FocusedState.Parent = this.txtRazonSocial;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazonSocial.HoverState.Parent = this.txtRazonSocial;
            this.txtRazonSocial.Location = new System.Drawing.Point(249, 471);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.PlaceholderText = "";
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.ShadowDecoration.Parent = this.txtRazonSocial;
            this.txtRazonSocial.Size = new System.Drawing.Size(203, 30);
            this.txtRazonSocial.TabIndex = 57;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Razon social";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.Black;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(249, 548);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PressedColor = System.Drawing.Color.Blue;
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(119, 28);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(452, 548);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.Blue;
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(119, 28);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRUC
            // 
            this.txtRUC.BorderColor = System.Drawing.Color.White;
            this.txtRUC.BorderRadius = 10;
            this.txtRUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRUC.DefaultText = "";
            this.txtRUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRUC.DisabledState.Parent = this.txtRUC;
            this.txtRUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRUC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtRUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRUC.FocusedState.Parent = this.txtRUC;
            this.txtRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.ForeColor = System.Drawing.Color.Black;
            this.txtRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRUC.HoverState.Parent = this.txtRUC;
            this.txtRUC.Location = new System.Drawing.Point(498, 471);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.PasswordChar = '\0';
            this.txtRUC.PlaceholderText = "";
            this.txtRUC.SelectedText = "";
            this.txtRUC.ShadowDecoration.Parent = this.txtRUC;
            this.txtRUC.Size = new System.Drawing.Size(203, 30);
            this.txtRUC.TabIndex = 62;
            // 
            // ldlRUC
            // 
            this.ldlRUC.AutoSize = true;
            this.ldlRUC.BackColor = System.Drawing.SystemColors.Window;
            this.ldlRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlRUC.Location = new System.Drawing.Point(494, 443);
            this.ldlRUC.Name = "ldlRUC";
            this.ldlRUC.Size = new System.Drawing.Size(49, 24);
            this.ldlRUC.TabIndex = 61;
            this.ldlRUC.Text = "RUC";
            // 
            // Nro
            // 
            this.Nro.FillWeight = 58.58155F;
            this.Nro.HeaderText = "ID.";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 84.7323F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // DNIRUC
            // 
            this.DNIRUC.FillWeight = 69.81967F;
            this.DNIRUC.HeaderText = "DNI/RUC";
            this.DNIRUC.Name = "DNIRUC";
            this.DNIRUC.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.FillWeight = 120.7118F;
            this.Username.HeaderText = "Nombre Completo";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // frm_Clientes_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 661);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.ldlRUC);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNIRUC);
            this.Controls.Add(this.lblDNIRuc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListarClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Clientes_Listar";
            this.Text = "Listar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListarClientes;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblDatosUsuario;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtDNIRUC;
        private System.Windows.Forms.Label lblDNIRuc;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtRUC;
        private System.Windows.Forms.Label ldlRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}