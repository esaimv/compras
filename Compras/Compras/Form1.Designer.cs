namespace Compras
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDataSet = new Compras.ProductoDataSet();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.StocktextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pRODUCTOTableAdapter = new Compras.ProductoDataSetTableAdapters.PRODUCTOTableAdapter();
            this.dataGridViewproducto = new System.Windows.Forms.DataGridView();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.Todosbtn = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.archivoToolStripMenuItem.Text = "Menu";
            this.archivoToolStripMenuItem.DropDownClosed += new System.EventHandler(this.archivoToolStripMenuItem_DropDownClosed);
            this.archivoToolStripMenuItem.DropDownOpened += new System.EventHandler(this.archivoToolStripMenuItem_DropDownOpened);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pedidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidosToolStripMenuItem.Image")));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.DropDownClosed += new System.EventHandler(this.pedidosToolStripMenuItem_DropDownClosed);
            this.pedidosToolStripMenuItem.DropDownOpened += new System.EventHandler(this.pedidosToolStripMenuItem_DropDownOpened);
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoPedidoToolStripMenuItem.Image")));
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarFacturaToolStripMenuItem,
            this.consultarFacturaToolStripMenuItem});
            this.facturaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.facturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaToolStripMenuItem.Image")));
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.facturaToolStripMenuItem.Text = "Facturas";
            this.facturaToolStripMenuItem.DropDownClosed += new System.EventHandler(this.facturaToolStripMenuItem_DropDownClosed);
            this.facturaToolStripMenuItem.DropDownOpened += new System.EventHandler(this.facturaToolStripMenuItem_DropDownOpened);
            // 
            // ingresarFacturaToolStripMenuItem
            // 
            this.ingresarFacturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresarFacturaToolStripMenuItem.Image")));
            this.ingresarFacturaToolStripMenuItem.Name = "ingresarFacturaToolStripMenuItem";
            this.ingresarFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ingresarFacturaToolStripMenuItem.Text = "Ingresar factura";
            this.ingresarFacturaToolStripMenuItem.Click += new System.EventHandler(this.ingresarFacturaToolStripMenuItem_Click);
            // 
            // consultarFacturaToolStripMenuItem
            // 
            this.consultarFacturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarFacturaToolStripMenuItem.Image")));
            this.consultarFacturaToolStripMenuItem.Name = "consultarFacturaToolStripMenuItem";
            this.consultarFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarFacturaToolStripMenuItem.Text = "Consultar factura";
            this.consultarFacturaToolStripMenuItem.Click += new System.EventHandler(this.consultarFacturaToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProveedorToolStripMenuItem,
            this.consultarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.DropDownClosed += new System.EventHandler(this.proveedoresToolStripMenuItem_DropDownClosed);
            this.proveedoresToolStripMenuItem.DropDownOpened += new System.EventHandler(this.proveedoresToolStripMenuItem_DropDownOpened);
            // 
            // ingresarProveedorToolStripMenuItem
            // 
            this.ingresarProveedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresarProveedorToolStripMenuItem.Image")));
            this.ingresarProveedorToolStripMenuItem.Name = "ingresarProveedorToolStripMenuItem";
            this.ingresarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ingresarProveedorToolStripMenuItem.Text = "Ingresar proveedor";
            this.ingresarProveedorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProveedorToolStripMenuItem_Click);
            // 
            // consultarProveedorToolStripMenuItem
            // 
            this.consultarProveedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarProveedorToolStripMenuItem.Image")));
            this.consultarProveedorToolStripMenuItem.Name = "consultarProveedorToolStripMenuItem";
            this.consultarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarProveedorToolStripMenuItem.Text = "Consultar proveedor";
            this.consultarProveedorToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedorToolStripMenuItem_Click);
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.productoDataSet;
            // 
            // productoDataSet
            // 
            this.productoDataSet.DataSetName = "ProductoDataSet";
            this.productoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.ForeColor = System.Drawing.Color.White;
            this.buttonguardar.Location = new System.Drawing.Point(194, 285);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(154, 33);
            this.buttonguardar.TabIndex = 8;
            this.buttonguardar.Text = "Guardar cambios";
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // buttonagregar
            // 
            this.buttonagregar.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonagregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonagregar.ForeColor = System.Drawing.Color.White;
            this.buttonagregar.Location = new System.Drawing.Point(365, 285);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(125, 33);
            this.buttonagregar.TabIndex = 4;
            this.buttonagregar.Text = "Agregar nuevo";
            this.buttonagregar.UseVisualStyleBackColor = false;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // StocktextBox
            // 
            this.StocktextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocktextBox.Location = new System.Drawing.Point(366, 79);
            this.StocktextBox.Name = "StocktextBox";
            this.StocktextBox.Size = new System.Drawing.Size(99, 23);
            this.StocktextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // TipotextBox
            // 
            this.TipotextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipotextBox.Location = new System.Drawing.Point(134, 234);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(258, 23);
            this.TipotextBox.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(134, 123);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(360, 92);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdtextBox.Location = new System.Drawing.Point(134, 79);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(99, 23);
            this.IdtextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(560, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultar inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresar pedido";
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewproducto
            // 
            this.dataGridViewproducto.AllowUserToAddRows = false;
            this.dataGridViewproducto.AllowUserToDeleteRows = false;
            this.dataGridViewproducto.AutoGenerateColumns = false;
            this.dataGridViewproducto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridViewproducto.DataSource = this.pRODUCTOBindingSource;
            this.dataGridViewproducto.Location = new System.Drawing.Point(681, 130);
            this.dataGridViewproducto.Name = "dataGridViewproducto";
            this.dataGridViewproducto.ReadOnly = true;
            this.dataGridViewproducto.Size = new System.Drawing.Size(444, 124);
            this.dataGridViewproducto.TabIndex = 0;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscartextBox.Location = new System.Drawing.Point(681, 79);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(161, 23);
            this.BuscartextBox.TabIndex = 1;
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.Buscarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.ForeColor = System.Drawing.Color.White;
            this.Buscarbtn.Location = new System.Drawing.Point(655, 285);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(86, 33);
            this.Buscarbtn.TabIndex = 2;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = false;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // Todosbtn
            // 
            this.Todosbtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.Todosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Todosbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todosbtn.ForeColor = System.Drawing.Color.White;
            this.Todosbtn.Location = new System.Drawing.Point(990, 285);
            this.Todosbtn.Name = "Todosbtn";
            this.Todosbtn.Size = new System.Drawing.Size(135, 33);
            this.Todosbtn.TabIndex = 3;
            this.Todosbtn.Text = "Desplegar todos";
            this.Todosbtn.UseVisualStyleBackColor = false;
            this.Todosbtn.Click += new System.EventHandler(this.Todosbtn_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.ForeColor = System.Drawing.Color.White;
            this.buttoneliminar.Location = new System.Drawing.Point(759, 285);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(97, 33);
            this.buttoneliminar.TabIndex = 8;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmodificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.ForeColor = System.Drawing.Color.White;
            this.buttonmodificar.Location = new System.Drawing.Point(873, 285);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(102, 33);
            this.buttonmodificar.TabIndex = 9;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = false;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID del Producto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(873, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1029, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(517, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 354);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1183, 405);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonagregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StocktextBox);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Todosbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.dataGridViewproducto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StocktextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProveedorToolStripMenuItem;
        private ProductoDataSet productoDataSet;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private ProductoDataSetTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.DataGridView dataGridViewproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Button Todosbtn;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

