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
    public partial class Form1 : Form
    {
        public string cadenaconexion;
        public string Sql;
        protected SqlConnection con;
        protected SqlCommand ComSql;
        public Form1()
        {
            this.cadenaconexion = (@"Data Source=.; Initial Catalog= COMPRAS; Integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }
        public void carga()
        {

            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PRODUCTO");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewproducto.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            p.Show();
            this.Hide();
        }

        private void ingresarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura ingresa = new Factura();
            ingresa.Show();
            this.Hide();

        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConltarFactura consulta = new ConltarFactura();
            consulta.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productoDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.productoDataSet.PRODUCTO);

        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PRODUCTO where id_producto='" + BuscartextBox.Text + "'");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewproducto.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

        }

        private void Todosbtn_Click(object sender, EventArgs e)
        {
            carga();
        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format("INSERT INTO PRODUCTO(id_producto, descripcion, tipo, stock) VALUES(@id,@desc,@tip,@stoc)");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();

            int idprodu = Convert.ToInt32(IdtextBox.Text);
            int stock = Convert.ToInt32(StocktextBox.Text);
            


            ComSql.Parameters.Add(new SqlParameter("@id", idprodu));
            ComSql.Parameters.Add(new SqlParameter("@desc", DescripciontextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@tip", TipotextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@stoc",stock));

            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            MessageBox.Show("Agregado al inventario!");
            this.con.Close();
            carga();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format("DELETE FROM PRODUCTO WHERE id_producto='" + BuscartextBox.Text + "'");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();
            MessageBox.Show("Se borro ");
            carga();
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format(@"Select id_producto, descripcion, tipo, stock FROM PRODUCTO WHERE id_producto='" + BuscartextBox.Text + "'");
            this.ComSql = new SqlCommand(this.Sql, this.con);
            this.con.Open();
            SqlDataReader reader = ComSql.ExecuteReader();

            if (reader.Read())
            {
                IdtextBox.Text = Convert.ToString(reader["id_producto"]);
                StocktextBox.Text = Convert.ToString(reader["stock"]);
                DescripciontextBox.Text = (string)reader["descripcion"];
                TipotextBox.Text = (string)reader["tipo"];
            }
            reader.Close();
            this.con.Close();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format("UPDATE PRODUCTO SET  descripcion= @desc, tipo= @tip, stock= @stoc WHERE id_producto = @id");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();

            int idprodu = Convert.ToInt32(IdtextBox.Text);
            int stock = Convert.ToInt32(StocktextBox.Text);



            ComSql.Parameters.Add(new SqlParameter("@id", idprodu));
            ComSql.Parameters.Add(new SqlParameter("@desc", DescripciontextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@tip", TipotextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@stoc", stock));

            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            MessageBox.Show("Producto Modificado!");
            this.con.Close();
            carga();


        }

        private void consultarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProveedor ingresa = new ConsultarProveedor();
            ingresa.Show();
            this.Hide();
        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProveedor insert = new IngresarProveedor();
            insert.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
