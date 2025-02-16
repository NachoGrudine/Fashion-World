namespace MenuPrincipalTPI.Presentacion
{
    partial class frmCargarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarProductos));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.gbxCargarProductos = new System.Windows.Forms.GroupBox();
            this.cboRubros = new System.Windows.Forms.ComboBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.gbxTalles = new System.Windows.Forms.GroupBox();
            this.checkTodas = new System.Windows.Forms.CheckBox();
            this.chkXXL = new System.Windows.Forms.CheckBox();
            this.chkXL = new System.Windows.Forms.CheckBox();
            this.chkL = new System.Windows.Forms.CheckBox();
            this.chkM = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.chkXS = new System.Windows.Forms.CheckBox();
            this.cboTipoPrenda = new System.Windows.Forms.ComboBox();
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.butGuardarCamb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCargarProductos.SuspendLayout();
            this.gbxTalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleName = "btnAceptar";
            this.btnAceptar.BackColor = System.Drawing.Color.Azure;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(8, 418);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(165, 64);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.AccessibleName = "lstProductos";
            this.lstProductos.BackColor = System.Drawing.Color.SeaShell;
            this.lstProductos.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 24;
            this.lstProductos.Location = new System.Drawing.Point(691, 38);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(345, 340);
            this.lstProductos.TabIndex = 1;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // gbxCargarProductos
            // 
            this.gbxCargarProductos.AccessibleName = "gbxCargarProductos";
            this.gbxCargarProductos.Controls.Add(this.cboRubros);
            this.gbxCargarProductos.Controls.Add(this.lblRubro);
            this.gbxCargarProductos.Controls.Add(this.txtPrecio);
            this.gbxCargarProductos.Controls.Add(this.lblPrecio);
            this.gbxCargarProductos.Controls.Add(this.gbxTalles);
            this.gbxCargarProductos.Controls.Add(this.cboTipoPrenda);
            this.gbxCargarProductos.Controls.Add(this.lblTipoPrenda);
            this.gbxCargarProductos.Controls.Add(this.cboGeneros);
            this.gbxCargarProductos.Controls.Add(this.lblGenero);
            this.gbxCargarProductos.Controls.Add(this.txtDescripcion);
            this.gbxCargarProductos.Controls.Add(this.lblDescripcion);
            this.gbxCargarProductos.Controls.Add(this.cboMarcas);
            this.gbxCargarProductos.Controls.Add(this.lblMarca);
            this.gbxCargarProductos.Controls.Add(this.txtProducto);
            this.gbxCargarProductos.Controls.Add(this.lblNombre);
            this.gbxCargarProductos.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCargarProductos.Location = new System.Drawing.Point(8, 2);
            this.gbxCargarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCargarProductos.Name = "gbxCargarProductos";
            this.gbxCargarProductos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCargarProductos.Size = new System.Drawing.Size(659, 400);
            this.gbxCargarProductos.TabIndex = 0;
            this.gbxCargarProductos.TabStop = false;
            // 
            // cboRubros
            // 
            this.cboRubros.AccessibleName = "cboRubros";
            this.cboRubros.BackColor = System.Drawing.Color.White;
            this.cboRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRubros.FormattingEnabled = true;
            this.cboRubros.Location = new System.Drawing.Point(184, 256);
            this.cboRubros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.Size = new System.Drawing.Size(255, 32);
            this.cboRubros.TabIndex = 5;
            // 
            // lblRubro
            // 
            this.lblRubro.AccessibleName = "lblRubro";
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(95, 256);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(56, 28);
            this.lblRubro.TabIndex = 38;
            this.lblRubro.Text = "Rubro";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AccessibleName = "txtPrecio";
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(184, 340);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(255, 32);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AccessibleName = "lblPrecio";
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(91, 340);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 28);
            this.lblPrecio.TabIndex = 36;
            this.lblPrecio.Text = "Precio";
            // 
            // gbxTalles
            // 
            this.gbxTalles.AccessibleName = "gbxTalles";
            this.gbxTalles.Controls.Add(this.checkTodas);
            this.gbxTalles.Controls.Add(this.chkXXL);
            this.gbxTalles.Controls.Add(this.chkXL);
            this.gbxTalles.Controls.Add(this.chkL);
            this.gbxTalles.Controls.Add(this.chkM);
            this.gbxTalles.Controls.Add(this.chkS);
            this.gbxTalles.Controls.Add(this.chkXS);
            this.gbxTalles.Location = new System.Drawing.Point(471, 214);
            this.gbxTalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTalles.Name = "gbxTalles";
            this.gbxTalles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTalles.Size = new System.Drawing.Size(169, 177);
            this.gbxTalles.TabIndex = 8;
            this.gbxTalles.TabStop = false;
            this.gbxTalles.Text = "Tallas:";
            // 
            // checkTodas
            // 
            this.checkTodas.AccessibleName = "checkTodas";
            this.checkTodas.AutoSize = true;
            this.checkTodas.Location = new System.Drawing.Point(40, 42);
            this.checkTodas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkTodas.Name = "checkTodas";
            this.checkTodas.Size = new System.Drawing.Size(69, 28);
            this.checkTodas.TabIndex = 6;
            this.checkTodas.Text = "Todas";
            this.checkTodas.UseVisualStyleBackColor = true;
            this.checkTodas.CheckedChanged += new System.EventHandler(this.checkTodas_CheckedChanged);
            // 
            // chkXXL
            // 
            this.chkXXL.AccessibleName = "chkXXL";
            this.chkXXL.AutoSize = true;
            this.chkXXL.Location = new System.Drawing.Point(104, 129);
            this.chkXXL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkXXL.Name = "chkXXL";
            this.chkXXL.Size = new System.Drawing.Size(55, 28);
            this.chkXXL.TabIndex = 5;
            this.chkXXL.Text = "XXL";
            this.chkXXL.UseVisualStyleBackColor = true;
            // 
            // chkXL
            // 
            this.chkXL.AccessibleName = "chkXL";
            this.chkXL.AutoSize = true;
            this.chkXL.Location = new System.Drawing.Point(104, 103);
            this.chkXL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkXL.Name = "chkXL";
            this.chkXL.Size = new System.Drawing.Size(47, 28);
            this.chkXL.TabIndex = 3;
            this.chkXL.Text = "XL";
            this.chkXL.UseVisualStyleBackColor = true;
            // 
            // chkL
            // 
            this.chkL.AccessibleName = "chkL";
            this.chkL.AutoSize = true;
            this.chkL.Location = new System.Drawing.Point(104, 78);
            this.chkL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkL.Name = "chkL";
            this.chkL.Size = new System.Drawing.Size(39, 28);
            this.chkL.TabIndex = 1;
            this.chkL.Text = "L";
            this.chkL.UseVisualStyleBackColor = true;
            // 
            // chkM
            // 
            this.chkM.AccessibleName = "chkM";
            this.chkM.AutoSize = true;
            this.chkM.Location = new System.Drawing.Point(23, 129);
            this.chkM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkM.Name = "chkM";
            this.chkM.Size = new System.Drawing.Size(43, 28);
            this.chkM.TabIndex = 4;
            this.chkM.Text = "M";
            this.chkM.UseVisualStyleBackColor = true;
            // 
            // chkS
            // 
            this.chkS.AccessibleName = "chkS";
            this.chkS.AutoSize = true;
            this.chkS.Location = new System.Drawing.Point(23, 103);
            this.chkS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(41, 28);
            this.chkS.TabIndex = 2;
            this.chkS.Text = "S";
            this.chkS.UseVisualStyleBackColor = true;
            // 
            // chkXS
            // 
            this.chkXS.AccessibleName = "chkXS";
            this.chkXS.AutoSize = true;
            this.chkXS.Location = new System.Drawing.Point(23, 78);
            this.chkXS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkXS.Name = "chkXS";
            this.chkXS.Size = new System.Drawing.Size(48, 28);
            this.chkXS.TabIndex = 0;
            this.chkXS.Text = "XS";
            this.chkXS.UseVisualStyleBackColor = true;
            // 
            // cboTipoPrenda
            // 
            this.cboTipoPrenda.AccessibleName = "cboTipoPrenda";
            this.cboTipoPrenda.BackColor = System.Drawing.Color.White;
            this.cboTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPrenda.FormattingEnabled = true;
            this.cboTipoPrenda.Location = new System.Drawing.Point(184, 297);
            this.cboTipoPrenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoPrenda.Name = "cboTipoPrenda";
            this.cboTipoPrenda.Size = new System.Drawing.Size(255, 32);
            this.cboTipoPrenda.TabIndex = 6;
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AccessibleName = "lblTipoPrenda";
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrenda.Location = new System.Drawing.Point(51, 297);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(101, 28);
            this.lblTipoPrenda.TabIndex = 27;
            this.lblTipoPrenda.Text = "Tipo prenda";
            // 
            // cboGeneros
            // 
            this.cboGeneros.AccessibleName = "cboGeneros";
            this.cboGeneros.BackColor = System.Drawing.Color.White;
            this.cboGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(184, 214);
            this.cboGeneros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(255, 32);
            this.cboGeneros.TabIndex = 4;
            // 
            // lblGenero
            // 
            this.lblGenero.AccessibleName = "lblGenero";
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(85, 214);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(66, 28);
            this.lblGenero.TabIndex = 25;
            this.lblGenero.Text = "Genero";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AccessibleName = "txtDescripcion";
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(184, 80);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(455, 86);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AccessibleName = "lblDescripcion";
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(59, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 28);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cboMarcas
            // 
            this.cboMarcas.AccessibleName = "cboMarcas";
            this.cboMarcas.BackColor = System.Drawing.Color.White;
            this.cboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(184, 172);
            this.cboMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(255, 32);
            this.cboMarcas.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AccessibleName = "lblMarca";
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(93, 172);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 28);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca";
            // 
            // txtProducto
            // 
            this.txtProducto.AccessibleName = "txtProducto";
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(184, 44);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(255, 32);
            this.txtProducto.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AccessibleName = "lblNombre";
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(142, 28);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleName = "btnCancelar";
            this.btnCancelar.BackColor = System.Drawing.Color.Azure;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(501, 418);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 64);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleName = "btnSalir";
            this.btnSalir.BackColor = System.Drawing.Color.Azure;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(845, 418);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 64);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "btnGuardar";
            this.btnGuardar.BackColor = System.Drawing.Color.Azure;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(252, 418);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 64);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // butGuardarCamb
            // 
            this.butGuardarCamb.AccessibleName = "btnCancelar";
            this.butGuardarCamb.BackColor = System.Drawing.Color.Azure;
            this.butGuardarCamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGuardarCamb.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardarCamb.Location = new System.Drawing.Point(39, 418);
            this.butGuardarCamb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGuardarCamb.Name = "butGuardarCamb";
            this.butGuardarCamb.Size = new System.Drawing.Size(204, 64);
            this.butGuardarCamb.TabIndex = 6;
            this.butGuardarCamb.Text = "Guardar Cambios";
            this.butGuardarCamb.UseVisualStyleBackColor = false;
            this.butGuardarCamb.Click += new System.EventHandler(this.butGuardarCamb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "COLA DE GUADADO:";
            // 
            // frmCargarProductos
            // 
            this.AccessibleName = "frmCargarProductos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1053, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butGuardarCamb);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.gbxCargarProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCargarProductos";
            this.Text = "CargarProductos";
            this.Load += new System.EventHandler(this.frmCargarProductos_Load);
            this.gbxCargarProductos.ResumeLayout(false);
            this.gbxCargarProductos.PerformLayout();
            this.gbxTalles.ResumeLayout(false);
            this.gbxTalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.GroupBox gbxCargarProductos;
        private System.Windows.Forms.ComboBox cboRubros;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox gbxTalles;
        private System.Windows.Forms.CheckBox chkXXL;
        private System.Windows.Forms.CheckBox chkXL;
        private System.Windows.Forms.CheckBox chkL;
        private System.Windows.Forms.CheckBox chkM;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.CheckBox chkXS;
        private System.Windows.Forms.ComboBox cboTipoPrenda;
        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox checkTodas;
        private System.Windows.Forms.Button butGuardarCamb;
        private System.Windows.Forms.Label label1;
    }
}