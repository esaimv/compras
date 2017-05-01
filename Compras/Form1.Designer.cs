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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.Todosbtn = new System.Windows.Forms.Button();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewproducto = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDataSet = new Compras.ProductoDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.archivoToolStripMenuItem.Text = "Menu";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarFacturaToolStripMenuItem,
            this.consultarFacturaToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturaToolStripMenuItem.Text = "Facturas";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // ingresarFacturaToolStripMenuItem
            // 
            this.ingresarFacturaToolStripMenuItem.Name = "ingresarFacturaToolStripMenuItem";
            this.ingresarFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ingresarFacturaToolStripMenuItem.Text = "Ingresar factura";
            this.ingresarFacturaToolStripMenuItem.Click += new System.EventHandler(this.ingresarFacturaToolStripMenuItem_Click);
            // 
            // consultarFacturaToolStripMenuItem
            // 
            this.consultarFacturaToolStripMenuItem.Name = "consultarFacturaToolStripMenuItem";
            this.consultarFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarFacturaToolStripMenuItem.Text = "Consultar factura";
            this.consultarFacturaToolStripMenuItem.Click += new System.EventHandler(this.consultarFacturaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedidoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProveedorToolStripMenuItem,
            this.consultarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // ingresarProveedorToolStripMenuItem
            // 
            this.ingresarProveedorToolStripMenuItem.Name = "ingresarProveedorToolStripMenuItem";
            this.ingresarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ingresarProveedorToolStripMenuItem.Text = "Ingresar proveedor";
            this.ingresarProveedorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProveedorToolStripMenuItem_Click);
            // 
            // consultarProveedorToolStripMenuItem
            // 
            this.consultarProveedorToolStripMenuItem.Name = "consultarProveedorToolStripMenuItem";
            this.consultarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarProveedorToolStripMenuItem.Text = "Consultar proveedor";
            this.consultarProveedorToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedorToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonmodificar);
            this.panel1.Controls.Add(this.buttoneliminar);
            this.panel1.Controls.Add(this.Todosbtn);
            this.panel1.Controls.Add(this.Buscarbtn);
            this.panel1.Controls.Add(this.BuscartextBox);
            this.panel1.Controls.Add(this.dataGridViewproducto);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 276);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Location = new System.Drawing.Point(567, 152);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(102, 29);
            this.buttonmodificar.TabIndex = 9;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = true;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(567, 113);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(97, 33);
            this.buttoneliminar.TabIndex = 8;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Todosbtn
            // 
            this.Todosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todosbtn.Location = new System.Drawing.Point(567, 187);
            this.Todosbtn.Name = "Todosbtn";
            this.Todosbtn.Size = new System.Drawing.Size(155, 36);
            this.Todosbtn.TabIndex = 3;
            this.Todosbtn.Text = "Desplegar todos";
            this.Todosbtn.UseVisualStyleBackColor = true;
            this.Todosbtn.Click += new System.EventHandler(this.Todosbtn_Click);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.Location = new System.Drawing.Point(567, 74);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(86, 33);
            this.Buscarbtn.TabIndex = 2;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscartextBox.Location = new System.Drawing.Point(223, 29);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(161, 26);
            this.BuscartextBox.TabIndex = 1;
            // 
            // dataGridViewproducto
            // 
            this.dataGridViewproducto.AllowUserToAddRows = false;
            this.dataGridViewproducto.AllowUserToDeleteRows = false;
            this.dataGridViewproducto.AutoGenerateColumns = false;
            this.dataGridViewproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridViewproducto.DataSource = this.pRODUCTOBindingSource;
            this.dataGridViewproducto.Location = new System.Drawing.Point(102, 73);
            this.dataGridViewproducto.Name = "dataGridViewproducto";
            this.dataGridViewproducto.ReadOnly = true;
            this.dataGridViewproducto.Size = new System.Drawing.Size(444, 124);
            this.dataGridViewproducto.TabIndex = 0;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonguardar);
            this.panel2.Controls.Add(this.buttonagregar);
            this.panel2.Controls.Add(this.StocktextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TipotextBox);
            this.panel2.Controls.Add(this.DescripciontextBox);
            this.panel2.Controls.Add(this.IdtextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(801, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 349);
            this.panel2.TabIndex = 2;
            // 
            // buttonguardar
            // 
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Location = new System.Drawing.Point(21, 288);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(153, 36);
            this.buttonguardar.TabIndex = 8;
            this.buttonguardar.Text = "Guardar Cambios";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // buttonagregar
            // 
            this.buttonagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonagregar.Location = new System.Drawing.Point(237, 288);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(125, 36);
            this.buttonagregar.TabIndex = 4;
            this.buttonagregar.Text = "Agregar Nuevo";
            this.buttonagregar.UseVisualStyleBackColor = true;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // StocktextBox
            // 
            this.StocktextBox.Location = new System.Drawing.Point(278, 35);
            this.StocktextBox.Name = "StocktextBox";
            this.StocktextBox.Size = new System.Drawing.Size(99, 20);
            this.StocktextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(113, 234);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(264, 20);
            this.TipotextBox.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(113, 73);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(264, 135);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(113, 35);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(99, 20);
            this.IdtextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID del producto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultar inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalles";
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Id del Producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewproducto;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button Todosbtn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Label label7;
    }
}

