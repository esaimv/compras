﻿namespace Compras
{
    partial class Pedido
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.preciounitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPedidoDataSet = new Compras.TablaPedidoDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NomprovpedidoCombo = new System.Windows.Forms.ComboBox();
            this.pROVEEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomProvedorDataSet = new Compras.NomProvedorDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Selecprodpedcombo = new System.Windows.Forms.ComboBox();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descProdDataSet = new Compras.DescProdDataSet();
            this.Importtext = new System.Windows.Forms.TextBox();
            this.medtext = new System.Windows.Forms.TextBox();
            this.DesctextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.canttext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preciountext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pROVEEDORTableAdapter = new Compras.NomProvedorDataSetTableAdapters.PROVEEDORTableAdapter();
            this.pRODUCTOTableAdapter = new Compras.DescProdDataSetTableAdapters.PRODUCTOTableAdapter();
            this.pEDIDOTableAdapter = new Compras.TablaPedidoDataSetTableAdapters.PEDIDOTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPedidoDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomProvedorDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descProdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(453, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 383);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preciounitarioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.idfacturaDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn,
            this.idempleadoDataGridViewTextBoxColumn,
            this.idproveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pEDIDOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // preciounitarioDataGridViewTextBoxColumn
            // 
            this.preciounitarioDataGridViewTextBoxColumn.DataPropertyName = "precio_unitario";
            this.preciounitarioDataGridViewTextBoxColumn.HeaderText = "precio_unitario";
            this.preciounitarioDataGridViewTextBoxColumn.Name = "preciounitarioDataGridViewTextBoxColumn";
            this.preciounitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idfacturaDataGridViewTextBoxColumn
            // 
            this.idfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.HeaderText = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.Name = "idfacturaDataGridViewTextBoxColumn";
            this.idfacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.tablaPedidoDataSet;
            // 
            // tablaPedidoDataSet
            // 
            this.tablaPedidoDataSet.DataSetName = "TablaPedidoDataSet";
            this.tablaPedidoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NomprovpedidoCombo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 52);
            this.panel2.TabIndex = 2;
            // 
            // NomprovpedidoCombo
            // 
            this.NomprovpedidoCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pROVEEDORBindingSource, "nombre", true));
            this.NomprovpedidoCombo.DataSource = this.pROVEEDORBindingSource;
            this.NomprovpedidoCombo.DisplayMember = "nombre";
            this.NomprovpedidoCombo.FormattingEnabled = true;
            this.NomprovpedidoCombo.Location = new System.Drawing.Point(313, 13);
            this.NomprovpedidoCombo.Name = "NomprovpedidoCombo";
            this.NomprovpedidoCombo.Size = new System.Drawing.Size(100, 21);
            this.NomprovpedidoCombo.TabIndex = 3;
            this.NomprovpedidoCombo.ValueMember = "nombre";
            // 
            // pROVEEDORBindingSource
            // 
            this.pROVEEDORBindingSource.DataMember = "PROVEEDOR";
            this.pROVEEDORBindingSource.DataSource = this.nomProvedorDataSet;
            // 
            // nomProvedorDataSet
            // 
            this.nomProvedorDataSet.DataSetName = "NomProvedorDataSet";
            this.nomProvedorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Selecprodpedcombo);
            this.panel3.Controls.Add(this.Importtext);
            this.panel3.Controls.Add(this.medtext);
            this.panel3.Controls.Add(this.DesctextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.canttext);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.preciountext);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 313);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar a Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Seleccionar Producto";
            // 
            // Selecprodpedcombo
            // 
            this.Selecprodpedcombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUCTOBindingSource, "descripcion", true));
            this.Selecprodpedcombo.DataSource = this.pRODUCTOBindingSource;
            this.Selecprodpedcombo.DisplayMember = "descripcion";
            this.Selecprodpedcombo.FormattingEnabled = true;
            this.Selecprodpedcombo.Location = new System.Drawing.Point(106, 54);
            this.Selecprodpedcombo.Name = "Selecprodpedcombo";
            this.Selecprodpedcombo.Size = new System.Drawing.Size(285, 21);
            this.Selecprodpedcombo.TabIndex = 12;
            this.Selecprodpedcombo.ValueMember = "descripcion";
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.descProdDataSet;
            // 
            // descProdDataSet
            // 
            this.descProdDataSet.DataSetName = "DescProdDataSet";
            this.descProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Importtext
            // 
            this.Importtext.Location = new System.Drawing.Point(300, 219);
            this.Importtext.Name = "Importtext";
            this.Importtext.Size = new System.Drawing.Size(100, 20);
            this.Importtext.TabIndex = 11;
            // 
            // medtext
            // 
            this.medtext.Location = new System.Drawing.Point(106, 223);
            this.medtext.Name = "medtext";
            this.medtext.Size = new System.Drawing.Size(100, 20);
            this.medtext.TabIndex = 10;
            // 
            // DesctextBox
            // 
            this.DesctextBox.Location = new System.Drawing.Point(106, 152);
            this.DesctextBox.Multiline = true;
            this.DesctextBox.Name = "DesctextBox";
            this.DesctextBox.Size = new System.Drawing.Size(294, 61);
            this.DesctextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Medida";
            // 
            // canttext
            // 
            this.canttext.Location = new System.Drawing.Point(300, 112);
            this.canttext.Name = "canttext";
            this.canttext.Size = new System.Drawing.Size(100, 20);
            this.canttext.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // preciountext
            // 
            this.preciountext.Location = new System.Drawing.Point(106, 112);
            this.preciountext.Name = "preciountext";
            this.preciountext.Size = new System.Drawing.Size(100, 20);
            this.preciountext.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Unitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Pedido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Detalles";
            // 
            // pROVEEDORTableAdapter
            // 
            this.pROVEEDORTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 434);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPedidoDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomProvedorDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descProdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox canttext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox preciountext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DesctextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox NomprovpedidoCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Selecprodpedcombo;
        private System.Windows.Forms.TextBox Importtext;
        private System.Windows.Forms.TextBox medtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private NomProvedorDataSet nomProvedorDataSet;
        private System.Windows.Forms.BindingSource pROVEEDORBindingSource;
        private NomProvedorDataSetTableAdapters.PROVEEDORTableAdapter pROVEEDORTableAdapter;
        private DescProdDataSet descProdDataSet;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private DescProdDataSetTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private TablaPedidoDataSet tablaPedidoDataSet;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private TablaPedidoDataSetTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
    }
}