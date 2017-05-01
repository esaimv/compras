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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_factext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewfactura = new System.Windows.Forms.DataGridView();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pedidooDataSet = new Compras.PedidooDataSet();
            this.pedidooDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDataSet = new Compras.FacturaDataSet();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURATableAdapter = new Compras.FacturaDataSetTableAdapters.FACTURATableAdapter();
            this.idfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarconsfacboton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(438, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha";
            // 
            // id_factext
            // 
            this.id_factext.Location = new System.Drawing.Point(182, 51);
            this.id_factext.Name = "id_factext";
            this.id_factext.Size = new System.Drawing.Size(156, 20);
            this.id_factext.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Número de Factura";
            // 
            // dataGridViewfactura
            // 
            this.dataGridViewfactura.AutoGenerateColumns = false;
            this.dataGridViewfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfacturaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.tipopagoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.idempleadoDataGridViewTextBoxColumn,
            this.idproveedorDataGridViewTextBoxColumn,
            this.idpedidoDataGridViewTextBoxColumn});
            this.dataGridViewfactura.DataSource = this.fACTURABindingSource;
            this.dataGridViewfactura.Location = new System.Drawing.Point(11, 100);
            this.dataGridViewfactura.Name = "dataGridViewfactura";
            this.dataGridViewfactura.Size = new System.Drawing.Size(843, 146);
            this.dataGridViewfactura.TabIndex = 29;
            this.dataGridViewfactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(888, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 35);
            this.button4.TabIndex = 33;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(888, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 32;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(888, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dataGridView2.Location = new System.Drawing.Point(12, 304);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 137);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Número de Pedido";
            // 
            // pedidooDataSet
            // 
            this.pedidooDataSet.DataSetName = "PedidooDataSet";
            this.pedidooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidooDataSetBindingSource
            // 
            this.pedidooDataSetBindingSource.DataSource = this.pedidooDataSet;
            this.pedidooDataSetBindingSource.Position = 0;
            // 
            // facturaDataSet
            // 
            this.facturaDataSet.DataSetName = "FacturaDataSet";
            this.facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            this.fACTURABindingSource.DataSource = this.facturaDataSet;
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
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
            // buscarconsfacboton
            // 
            this.buscarconsfacboton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarconsfacboton.Location = new System.Drawing.Point(888, 86);
            this.buscarconsfacboton.Name = "buscarconsfacboton";
            this.buscarconsfacboton.Size = new System.Drawing.Size(88, 34);
            this.buscarconsfacboton.TabIndex = 38;
            this.buscarconsfacboton.Text = "Buscar";
            this.buscarconsfacboton.UseVisualStyleBackColor = true;
            this.buscarconsfacboton.Click += new System.EventHandler(this.buscarconsfacboton_Click);
            // 
            // ConltarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 605);
            this.Controls.Add(this.buscarconsfacboton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewfactura);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_factext);
            this.Controls.Add(this.label6);
            this.Name = "ConltarFactura";
            this.Text = "ConltarFactura";
            this.Load += new System.EventHandler(this.ConltarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidooDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_factext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewfactura;
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
    }
}