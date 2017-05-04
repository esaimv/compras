namespace Compras
{
    partial class ConltarFactura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConltarFactura));
            this.id_factext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewfacturac = new System.Windows.Forms.DataGridView();
            this.idfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDataSet = new Compras.FacturaDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrpción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidooDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidooDataSet = new Compras.PedidooDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fACTURATableAdapter = new Compras.FacturaDataSetTableAdapters.FACTURATableAdapter();
            this.buscarconsfacboton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfacturac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_factext
            // 
            this.id_factext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_factext.Location = new System.Drawing.Point(160, 80);
            this.id_factext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_factext.Name = "id_factext";
            this.id_factext.Size = new System.Drawing.Size(207, 23);
            this.id_factext.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Número de Factura:";
            // 
            // dataGridViewfacturac
            // 
            this.dataGridViewfacturac.AutoGenerateColumns = false;
            this.dataGridViewfacturac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfacturac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfacturaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.tipopagoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.idempleadoDataGridViewTextBoxColumn,
            this.idproveedorDataGridViewTextBoxColumn,
            this.idpedidoDataGridViewTextBoxColumn});
            this.dataGridViewfacturac.DataSource = this.fACTURABindingSource;
            this.dataGridViewfacturac.Location = new System.Drawing.Point(13, 127);
            this.dataGridViewfacturac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewfacturac.Name = "dataGridViewfacturac";
            this.dataGridViewfacturac.Size = new System.Drawing.Size(843, 178);
            this.dataGridViewfacturac.TabIndex = 29;
            this.dataGridViewfacturac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idfacturaDataGridViewTextBoxColumn
            // 
            this.idfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.HeaderText = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.Name = "idfacturaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // tipopagoDataGridViewTextBoxColumn
            // 
            this.tipopagoDataGridViewTextBoxColumn.DataPropertyName = "tipo_pago";
            this.tipopagoDataGridViewTextBoxColumn.HeaderText = "tipo_pago";
            this.tipopagoDataGridViewTextBoxColumn.Name = "tipopagoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            this.fACTURABindingSource.DataSource = this.facturaDataSet;
            // 
            // facturaDataSet
            // 
            this.facturaDataSet.DataSetName = "FacturaDataSet";
            this.facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrchid;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(878, 270);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 35);
            this.button4.TabIndex = 33;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrchid;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(878, 127);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 35);
            this.button3.TabIndex = 32;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(878, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Descrpción,
            this.Cantidad,
            this.Medida,
            this.Precio_unitario,
            this.Importe});
            this.dataGridView2.DataSource = this.pedidooDataSetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 390);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(644, 179);
            this.dataGridView2.TabIndex = 35;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Descrpción
            // 
            this.Descrpción.HeaderText = "Descripción";
            this.Descrpción.Name = "Descrpción";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio Unitario";
            this.Precio_unitario.Name = "Precio_unitario";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // pedidooDataSetBindingSource
            // 
            this.pedidooDataSetBindingSource.DataSource = this.pedidooDataSet;
            this.pedidooDataSetBindingSource.Position = 0;
            // 
            // pedidooDataSet
            // 
            this.pedidooDataSet.DataSetName = "PedidooDataSet";
            this.pedidooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(160, 351);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 23);
            this.textBox3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Número de Pedido:";
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
            // 
            // buscarconsfacboton
            // 
            this.buscarconsfacboton.BackColor = System.Drawing.Color.DarkOrchid;
            this.buscarconsfacboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarconsfacboton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarconsfacboton.ForeColor = System.Drawing.Color.White;
            this.buscarconsfacboton.Location = new System.Drawing.Point(388, 75);
            this.buscarconsfacboton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscarconsfacboton.Name = "buscarconsfacboton";
            this.buscarconsfacboton.Size = new System.Drawing.Size(99, 32);
            this.buscarconsfacboton.TabIndex = 38;
            this.buscarconsfacboton.Text = "Buscar";
            this.buscarconsfacboton.UseVisualStyleBackColor = false;
            this.buscarconsfacboton.Click += new System.EventHandler(this.buscarconsfacboton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Consultar";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip2.TabIndex = 40;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.DropDownClosed += new System.EventHandler(this.toolStripMenuItem1_DropDownClosed);
            this.toolStripMenuItem1.DropDownOpened += new System.EventHandler(this.toolStripMenuItem1_DropDownOpened);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Salir";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem3.Text = "Pedidos";
            this.toolStripMenuItem3.DropDownClosed += new System.EventHandler(this.toolStripMenuItem3_DropDownClosed);
            this.toolStripMenuItem3.DropDownOpened += new System.EventHandler(this.toolStripMenuItem3_DropDownOpened);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "Nuevo pedido";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem5.Text = "Facturas";
            this.toolStripMenuItem5.DropDownClosed += new System.EventHandler(this.toolStripMenuItem5_DropDownClosed);
            this.toolStripMenuItem5.DropDownOpened += new System.EventHandler(this.toolStripMenuItem5_DropDownOpened);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem6.Text = "Ingresar factura";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem7.Text = "Consultar factura";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItem8.Text = "Proveedores";
            this.toolStripMenuItem8.DropDownClosed += new System.EventHandler(this.toolStripMenuItem8_DropDownClosed);
            this.toolStripMenuItem8.DropDownOpened += new System.EventHandler(this.toolStripMenuItem8_DropDownOpened);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem9.Text = "Ingresar proveedor";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem10.Text = "Consultar proveedor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(900, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(684, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ConltarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1032, 582);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarconsfacboton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewfacturac);
            this.Controls.Add(this.id_factext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ConltarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Factura";
            this.Load += new System.EventHandler(this.ConltarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfacturac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_factext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewfacturac;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrpción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.BindingSource pedidooDataSetBindingSource;
        private PedidooDataSet pedidooDataSet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private FacturaDataSet facturaDataSet;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private FacturaDataSetTableAdapters.FACTURATableAdapter fACTURATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buscarconsfacboton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}