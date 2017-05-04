using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Compras
{
    public partial class Pedido : Form
    {
        public string cadenaconexion;
        public string Sql;
        protected SqlConnection con;
        protected SqlCommand ComSql;

        public Pedido()
        {
            this.cadenaconexion = (@"Data Source=.; Initial Catalog= COMPRAS; Integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

   

        private void Pedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productoDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter1.Fill(this.productoDataSet.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'provedor_idDataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter1.Fill(this.provedor_idDataSet.PROVEEDOR);
            // TODO: esta línea de código carga datos en la tabla 'pedidooDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.
            this.pEDIDOTableAdapter1.Fill(this.pedidooDataSet.PEDIDO);
            // TODO: esta línea de código carga datos en la tabla 'tablaPedidoDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'descProdDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.descProdDataSet.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'nomProvedorDataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.nomProvedorDataSet.PROVEEDOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format("INSERT INTO PEDIDO(id_pedido, precio_unitario, cantidad, medida, descripcion, importe, id_producto, id_proveedor) VALUES(@id, @precio,@cantidad,@medida,@descr,@importe,@id_producto, @id_proveedor)");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();

            int id = Convert.ToInt32(id_pedidotex.Text);
            double precio = Convert.ToDouble(preciountext.Text);
            int cant = Convert.ToInt32(canttext.Text);
            double importe = Convert.ToDouble(Importtext.Text);
            int id_pr = Convert.ToInt32(Selecprodpedcombo.Text);
            int id_prov = Convert.ToInt32(comboìdprov.Text);
            ComSql.Parameters.Add(new SqlParameter("@id", id));
            ComSql.Parameters.Add(new SqlParameter("@precio", precio));
            ComSql.Parameters.Add(new SqlParameter("@cantidad", cant));
            ComSql.Parameters.Add(new SqlParameter("@medida", medtext.Text));
            ComSql.Parameters.Add(new SqlParameter("@descr", DesctextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@importe", importe));
            ComSql.Parameters.Add(new SqlParameter("@id_producto", id_pr));
            ComSql.Parameters.Add(new SqlParameter("@id_proveedor", id_prov));

            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            MessageBox.Show("Agregado al inventario!");
            this.con.Close();

            id_pedidotex.Text = "";
            preciountext.Text = "";
            canttext.Text = "";
            Importtext.Text = "";
            medtext.Text = "";
            DesctextBox.Text = "";


            carga();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void busprovpedidoboton_Click(object sender, EventArgs e)
        {

            this.Sql = string.Format(@"Select nombre, telefono, direccion FROM PROVEEDOR WHERE id_proveedor='" + comboìdprov.Text + "'");
            this.ComSql = new SqlCommand(this.Sql, this.con);
            this.con.Open();
            SqlDataReader reader = ComSql.ExecuteReader();

            if (reader.Read())
            {
                nombretext.Text = (string)reader["nombre"];
                direcciontext.Text = (string)reader["direccion"];
                teltext.Text = Convert.ToString(reader["telefono"]);
            }
            reader.Close();
            this.con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format(@"Select descripcion, stock FROM PRODUCTO WHERE id_producto='" + Selecprodpedcombo.Text + "'");
            this.ComSql = new SqlCommand(this.Sql, this.con);
            this.con.Open();
            SqlDataReader reader = ComSql.ExecuteReader();

            if (reader.Read())
            {
                nomprotext.Text = (string)reader["descripcion"];
                stocktext.Text = Convert.ToString(reader["stock"]);
            }
            reader.Close();
            this.con.Close();

        }

        public void carga()
        {

            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PEDIDO");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewPedido.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura ingresa = new Factura();
            ingresa.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_DropDownClosed(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;
        }

        private void toolStripMenuItem1_DropDownOpened(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.Black; 
        }

        private void toolStripMenuItem3_DropDownClosed(object sender, EventArgs e)
        {
            toolStripMenuItem3.ForeColor = Color.White;
        }

        private void toolStripMenuItem3_DropDownOpened(object sender, EventArgs e)
        {
            toolStripMenuItem3.ForeColor = Color.Black;
        }

        private void toolStripMenuItem5_DropDownClosed(object sender, EventArgs e)
        {
            toolStripMenuItem5.ForeColor = Color.White;
        }

        private void toolStripMenuItem5_DropDownOpened(object sender, EventArgs e)
        {
            toolStripMenuItem5.ForeColor = Color.Black;
        }

        private void toolStripMenuItem8_DropDownClosed(object sender, EventArgs e)
        {
            toolStripMenuItem8.ForeColor = Color.White;
        }

        private void toolStripMenuItem8_DropDownOpened(object sender, EventArgs e)
        {
            toolStripMenuItem8.ForeColor = Color.Black;
        }
    }
}
