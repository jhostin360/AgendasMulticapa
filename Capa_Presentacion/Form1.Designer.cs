namespace Capa_Presentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PicBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtMovil = new System.Windows.Forms.TextBox();
            this.TxtEstado_civil = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSeleccionar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlTop.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.PnlTop.Controls.Add(this.panel8);
            this.PnlTop.Controls.Add(this.panel6);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(807, 58);
            this.PnlTop.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.PicBoxCerrar);
            this.panel8.Location = new System.Drawing.Point(683, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(124, 22);
            this.panel8.TabIndex = 0;
            // 
            // PicBoxCerrar
            // 
            this.PicBoxCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCerrar.Image")));
            this.PicBoxCerrar.Location = new System.Drawing.Point(100, 0);
            this.PicBoxCerrar.Name = "PicBoxCerrar";
            this.PicBoxCerrar.Size = new System.Drawing.Size(24, 22);
            this.PicBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCerrar.TabIndex = 0;
            this.PicBoxCerrar.TabStop = false;
            this.PicBoxCerrar.Click += new System.EventHandler(this.PicBoxCerrar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 58);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel7.Location = new System.Drawing.Point(62, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 10);
            this.panel7.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa_Presentacion.Properties.Resources.icons8_agenda_64;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda Electronica";
            // 
            // MoverForm
            // 
            this.MoverForm.Fixed = true;
            this.MoverForm.Horizontal = true;
            this.MoverForm.TargetControl = this.PnlTop;
            this.MoverForm.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 425);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSeleccionar);
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.DGV);
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 372);
            this.panel1.TabIndex = 2;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrar.BorderRadius = 5;
            this.BtnBorrar.ButtonText = "Borrar";
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBorrar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBorrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Iconimage")));
            this.BtnBorrar.Iconimage_right = null;
            this.BtnBorrar.Iconimage_right_Selected = null;
            this.BtnBorrar.Iconimage_Selected = null;
            this.BtnBorrar.IconMarginLeft = 0;
            this.BtnBorrar.IconMarginRight = 0;
            this.BtnBorrar.IconRightVisible = true;
            this.BtnBorrar.IconRightZoom = 0D;
            this.BtnBorrar.IconVisible = true;
            this.BtnBorrar.IconZoom = 90D;
            this.BtnBorrar.IsTab = false;
            this.BtnBorrar.Location = new System.Drawing.Point(260, 311);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.BtnBorrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.BtnBorrar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBorrar.selected = false;
            this.BtnBorrar.Size = new System.Drawing.Size(114, 58);
            this.BtnBorrar.TabIndex = 13;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrar.Textcolor = System.Drawing.Color.Black;
            this.BtnBorrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 5;
            this.BtnEditar.ButtonText = "Editar";
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Iconimage")));
            this.BtnEditar.Iconimage_right = null;
            this.BtnEditar.Iconimage_right_Selected = null;
            this.BtnEditar.Iconimage_Selected = null;
            this.BtnEditar.IconMarginLeft = 0;
            this.BtnEditar.IconMarginRight = 0;
            this.BtnEditar.IconRightVisible = true;
            this.BtnEditar.IconRightZoom = 0D;
            this.BtnEditar.IconVisible = true;
            this.BtnEditar.IconZoom = 90D;
            this.BtnEditar.IsTab = false;
            this.BtnEditar.Location = new System.Drawing.Point(140, 311);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(134)))), ((int)(((byte)(48)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(114, 58);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.Black;
            this.BtnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 5;
            this.BtnGuardar.ButtonText = "Guargar";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Iconimage")));
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 90D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(16, 311);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(118, 58);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guargar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.Black;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(15, 16);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(537, 289);
            this.DGV.TabIndex = 10;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.TxtBuscar);
            this.panel5.Location = new System.Drawing.Point(12, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 41);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.icons8_búsqueda_24;
            this.pictureBox1.Location = new System.Drawing.Point(349, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(3, 7);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(340, 30);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.Text = "Buscar";
            this.TxtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtTelefono);
            this.panel4.Controls.Add(this.TxtCorreo);
            this.panel4.Controls.Add(this.TxtMovil);
            this.panel4.Controls.Add(this.TxtEstado_civil);
            this.panel4.Controls.Add(this.TxtApellido);
            this.panel4.Controls.Add(this.TxtFecha);
            this.panel4.Controls.Add(this.TxtDireccion);
            this.panel4.Controls.Add(this.TxtGenero);
            this.panel4.Controls.Add(this.TxtNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(571, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 425);
            this.panel4.TabIndex = 1;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.TxtTelefono.Location = new System.Drawing.Point(6, 337);
            this.TxtTelefono.Multiline = true;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(221, 37);
            this.TxtTelefono.TabIndex = 8;
            this.TxtTelefono.Text = "Telefono";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.TxtCorreo.Location = new System.Drawing.Point(6, 380);
            this.TxtCorreo.Multiline = true;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(221, 37);
            this.TxtCorreo.TabIndex = 7;
            this.TxtCorreo.Text = "Correo-Electronico";
            // 
            // TxtMovil
            // 
            this.TxtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMovil.ForeColor = System.Drawing.Color.Gray;
            this.TxtMovil.Location = new System.Drawing.Point(6, 294);
            this.TxtMovil.Multiline = true;
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(221, 37);
            this.TxtMovil.TabIndex = 6;
            this.TxtMovil.Text = "Movil";
            // 
            // TxtEstado_civil
            // 
            this.TxtEstado_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado_civil.ForeColor = System.Drawing.Color.Gray;
            this.TxtEstado_civil.Location = new System.Drawing.Point(6, 251);
            this.TxtEstado_civil.Multiline = true;
            this.TxtEstado_civil.Name = "TxtEstado_civil";
            this.TxtEstado_civil.Size = new System.Drawing.Size(221, 37);
            this.TxtEstado_civil.TabIndex = 5;
            this.TxtEstado_civil.Text = "Estado Civil";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.Gray;
            this.TxtApellido.Location = new System.Drawing.Point(3, 79);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(221, 37);
            this.TxtApellido.TabIndex = 4;
            this.TxtApellido.Text = "Apellido";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.ForeColor = System.Drawing.Color.Gray;
            this.TxtFecha.Location = new System.Drawing.Point(3, 122);
            this.TxtFecha.Multiline = true;
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(221, 37);
            this.TxtFecha.TabIndex = 3;
            this.TxtFecha.Text = "Fecha de Nacimiento";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.Gray;
            this.TxtDireccion.Location = new System.Drawing.Point(6, 165);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(221, 37);
            this.TxtDireccion.TabIndex = 2;
            this.TxtDireccion.Text = "Direccion";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenero.ForeColor = System.Drawing.Color.Gray;
            this.TxtGenero.Location = new System.Drawing.Point(6, 208);
            this.TxtGenero.Multiline = true;
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(221, 37);
            this.TxtGenero.TabIndex = 1;
            this.TxtGenero.Text = "Genero";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Gray;
            this.TxtNombre.Location = new System.Drawing.Point(6, 36);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(221, 37);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 425);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeleccionar.BorderRadius = 5;
            this.BtnSeleccionar.ButtonText = "Seleccionar";
            this.BtnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeleccionar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSeleccionar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSeleccionar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Iconimage")));
            this.BtnSeleccionar.Iconimage_right = null;
            this.BtnSeleccionar.Iconimage_right_Selected = null;
            this.BtnSeleccionar.Iconimage_Selected = null;
            this.BtnSeleccionar.IconMarginLeft = 0;
            this.BtnSeleccionar.IconMarginRight = 0;
            this.BtnSeleccionar.IconRightVisible = true;
            this.BtnSeleccionar.IconRightZoom = 0D;
            this.BtnSeleccionar.IconVisible = true;
            this.BtnSeleccionar.IconZoom = 90D;
            this.BtnSeleccionar.IsTab = false;
            this.BtnSeleccionar.Location = new System.Drawing.Point(380, 311);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Normalcolor = System.Drawing.Color.Aquamarine;
            this.BtnSeleccionar.OnHovercolor = System.Drawing.Color.Turquoise;
            this.BtnSeleccionar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSeleccionar.selected = false;
            this.BtnSeleccionar.Size = new System.Drawing.Size(144, 58);
            this.BtnSeleccionar.TabIndex = 14;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Textcolor = System.Drawing.Color.Black;
            this.BtnSeleccionar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agenda Electronica";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.PnlTop.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox PicBoxCerrar;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuDragControl MoverForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBorrar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtMovil;
        private System.Windows.Forms.TextBox TxtEstado_civil;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSeleccionar;
    }
}

