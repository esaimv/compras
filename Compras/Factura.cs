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
    public partial class Factura : Form
    {
        public string cadenaconexion;
        public string Sql;
        protected SqlConnection con;
        protected SqlCommand ComSql;
        public Factura()
        {
            this.cadenaconexion = (@"Data Source=.; Initial Catalog= COMPRAS; Integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }



        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pedidooDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.
            this.pEDIDOTableAdapter1.Fill(this.pedidooDataSet.PEDIDO);
            // TODO: esta línea de código carga datos en la tabla 'pedidoDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'provedor_idDataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.provedor_idDataSet.PROVEEDOR);

        }

        private void Clientecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format(@"Select nombre, telefono, email, direccion, rfc, codigo_postal FROM PROVEEDOR WHERE id_proveedor='" + Clientecombo.Text+"'");
            this.ComSql = new SqlCommand(this.Sql, this.con);
            this.con.Open();
            SqlDataReader reader = ComSql.ExecuteReader();

            if (reader.Read()) {
                nombretext.Text = (string)reader["nombre"];
                Direcctext.Text = (string)reader["direccion"];
                teltext.Text = Convert.ToString(reader["telefono"]);
                emailtext.Text = (string)reader["email"];
                rfctext.Text = (string)reader["rfc"];
                cod_postaltext.Text = Convert.ToString(reader["codigo_postal"]);
            }
            reader.Close();
            this.con.Close();

            

        
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProveedor insert = new IngresarProveedor();
            insert.Show();
            this.Hide();
        }

        private void consultarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProveedor ingresa = new ConsultarProveedor();
            ingresa.Show();
            this.Hide();
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 pedido = new Form1();
            pedido.Show();
            this.Hide();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PEDIDO where id_pedido='" + combopedido.Text + "'");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewpedidof.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

        }
    }
}
