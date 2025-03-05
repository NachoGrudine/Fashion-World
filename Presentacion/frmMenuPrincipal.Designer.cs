namespace MenuPrincipalTPI
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fashionWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parteDatosTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textCadenaConexion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.butConectar = new System.Windows.Forms.Button();
            this.labelConexion = new System.Windows.Forms.Label();
            this.labeLink = new System.Windows.Forms.Label();
            this.butSql = new System.Windows.Forms.Button();
            this.lblFashionWord = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.parteDatosTPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1198, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.archivoToolStripMenuItem.Text = "Archivo...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.salirToolStripMenuItem.Text = "Salir...";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosotrosToolStripMenuItem,
            this.fashionWordToolStripMenuItem});
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            this.nosotrosToolStripMenuItem.Click += new System.EventHandler(this.nosotrosToolStripMenuItem_Click);
            // 
            // fashionWordToolStripMenuItem
            // 
            this.fashionWordToolStripMenuItem.Name = "fashionWordToolStripMenuItem";
            this.fashionWordToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.fashionWordToolStripMenuItem.Text = "Fashion Word";
            this.fashionWordToolStripMenuItem.Click += new System.EventHandler(this.fashionWordToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem,
            this.cargarProductosToolStripMenuItem,
            this.cargarDatosToolStripMenuItem});
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.soporteToolStripMenuItem.Text = "Soporte...";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.verProductosToolStripMenuItem.Text = "Ver productos...";
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // cargarProductosToolStripMenuItem
            // 
            this.cargarProductosToolStripMenuItem.Name = "cargarProductosToolStripMenuItem";
            this.cargarProductosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cargarProductosToolStripMenuItem.Text = "Cargar productos...";
            this.cargarProductosToolStripMenuItem.Click += new System.EventHandler(this.cargarProductosToolStripMenuItem_Click);
            // 
            // cargarDatosToolStripMenuItem
            // 
            this.cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            this.cargarDatosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cargarDatosToolStripMenuItem.Text = "Cargar datos...";
            this.cargarDatosToolStripMenuItem.Click += new System.EventHandler(this.cargarDatosToolStripMenuItem_Click);
            // 
            // parteDatosTPToolStripMenuItem
            // 
            this.parteDatosTPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem1});
            this.parteDatosTPToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.parteDatosTPToolStripMenuItem.Name = "parteDatosTPToolStripMenuItem";
            this.parteDatosTPToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.parteDatosTPToolStripMenuItem.Text = "Parte Datos TP";
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            this.consultasToolStripMenuItem1.Click += new System.EventHandler(this.consultasToolStripMenuItem1_Click);
            // 
            // textCadenaConexion
            // 
            this.textCadenaConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCadenaConexion.BackColor = System.Drawing.Color.SeaShell;
            this.textCadenaConexion.Location = new System.Drawing.Point(149, 150);
            this.textCadenaConexion.Margin = new System.Windows.Forms.Padding(4);
            this.textCadenaConexion.Name = "textCadenaConexion";
            this.textCadenaConexion.Size = new System.Drawing.Size(695, 22);
            this.textCadenaConexion.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // butConectar
            // 
            this.butConectar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butConectar.BackColor = System.Drawing.Color.Azure;
            this.butConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConectar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConectar.ForeColor = System.Drawing.Color.Black;
            this.butConectar.Location = new System.Drawing.Point(872, 138);
            this.butConectar.Margin = new System.Windows.Forms.Padding(4);
            this.butConectar.Name = "butConectar";
            this.butConectar.Size = new System.Drawing.Size(95, 38);
            this.butConectar.TabIndex = 12;
            this.butConectar.Text = "Conectar";
            this.butConectar.UseVisualStyleBackColor = false;
            this.butConectar.Click += new System.EventHandler(this.butConectar_Click);
            // 
            // labelConexion
            // 
            this.labelConexion.AccessibleName = "labelConexion";
            this.labelConexion.AutoSize = true;
            this.labelConexion.Location = new System.Drawing.Point(1031, 123);
            this.labelConexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConexion.Name = "labelConexion";
            this.labelConexion.Size = new System.Drawing.Size(0, 16);
            this.labelConexion.TabIndex = 14;
            // 
            // labeLink
            // 
            this.labeLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labeLink.AutoSize = true;
            this.labeLink.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLink.ForeColor = System.Drawing.Color.Black;
            this.labeLink.Location = new System.Drawing.Point(144, 123);
            this.labeLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeLink.Name = "labeLink";
            this.labeLink.Size = new System.Drawing.Size(309, 24);
            this.labeLink.TabIndex = 15;
            this.labeLink.Text = "INGRESE UN LINK DE CONEXION A SQL SERVER:";
            // 
            // butSql
            // 
            this.butSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSql.BackColor = System.Drawing.Color.SeaShell;
            this.butSql.BackgroundImage = global::MenuPrincipalTPI.Properties.Resources.Rojo;
            this.butSql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSql.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSql.ForeColor = System.Drawing.Color.Black;
            this.butSql.Location = new System.Drawing.Point(1034, 13);
            this.butSql.Margin = new System.Windows.Forms.Padding(4);
            this.butSql.Name = "butSql";
            this.butSql.Size = new System.Drawing.Size(129, 87);
            this.butSql.TabIndex = 13;
            this.butSql.Text = "SQL";
            this.butSql.UseVisualStyleBackColor = false;
            this.butSql.Click += new System.EventHandler(this.butSql_Click);
            // 
            // lblFashionWord
            // 
            this.lblFashionWord.AccessibleName = "lblFashionWord";
            this.lblFashionWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFashionWord.BackColor = System.Drawing.Color.Transparent;
            this.lblFashionWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFashionWord.Font = new System.Drawing.Font("Goudy Old Style", 85.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFashionWord.ForeColor = System.Drawing.Color.Olive;
            this.lblFashionWord.Location = new System.Drawing.Point(12, 216);
            this.lblFashionWord.Name = "lblFashionWord";
            this.lblFashionWord.Size = new System.Drawing.Size(1034, 138);
            this.lblFashionWord.TabIndex = 6;
            this.lblFashionWord.Text = "Fashion World";
            this.lblFashionWord.Click += new System.EventHandler(this.lblFashionWord_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AccessibleName = "frmMenuPrincipal";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1198, 518);
            this.Controls.Add(this.labeLink);
            this.Controls.Add(this.labelConexion);
            this.Controls.Add(this.butSql);
            this.Controls.Add(this.butConectar);
            this.Controls.Add(this.textCadenaConexion);
            this.Controls.Add(this.lblFashionWord);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Olive;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox textCadenaConexion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button butConectar;
        private System.Windows.Forms.Button butSql;
        private System.Windows.Forms.Label labelConexion;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fashionWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parteDatosTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.Label labeLink;
        private System.Windows.Forms.Label lblFashionWord;
    }
}

