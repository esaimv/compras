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


            this.Sql = string.Format(@"Select id_pedido FROM PEDIDO");
            this.ComSql = new SqlCommand(this.Sql, this.con);
            this.con.Open();


            SqlDataReader dr = ComSql.ExecuteReader();

            List<string> lista = new List<string>();

            while (dr.Read())
            {
                lista.Add(dr[0].ToString());

            }
            lista = lista.Distinct().ToList();
            combopedido.DataSource = lista;

            con.Close();

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
            this.Sql = string.Format("INSERT INTO FACTURA (id_factura, total, tipo_pago, fecha, sub_total, id_proveedor, id_pedido) VALUES (@id_fac, @total, @tipo, @fecha, @subtotal, @idpro, @idpedido);");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();


            int idfact = Convert.ToInt32(idfactext.Text);
            int idprov = Convert.ToInt32(Clientecombo.Text);
            int idpedido = Convert.ToInt32(combopedido.Text);
            double total = Convert.ToDouble(totaltext.Text);
            double subtotal = Convert.ToDouble(subtext.Text);
            string fechacon = fecha.Value.ToString("yyyy-MM-dd");

            ComSql.Parameters.Add(new SqlParameter("@id_fac", idfact));
            ComSql.Parameters.Add(new SqlParameter("@total", total));
            ComSql.Parameters.Add(new SqlParameter("@tipo", formpatext.Text));
            ComSql.Parameters.Add(new SqlParameter("@fecha", fechacon));
            ComSql.Parameters.Add(new SqlParameter("@subtotal", subtotal));
            ComSql.Parameters.Add(new SqlParameter("@idpro", idprov));
            ComSql.Parameters.Add(new SqlParameter("@idpedido", idpedido));

            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            MessageBox.Show("Factura agregada!");
            Reg.Close();

            /*this.con.Close();*/

            // Esto sera para hacer una lista con el id de productos pedidos
                    this.Sql = string.Format(@"Select id_producto FROM PEDIDO where id_pedido='"+idpedido+"'");
                     this.ComSql = new SqlCommand(this.Sql, this.con);
                     /*this.con.Open();*/
                     SqlDataReader dre = ComSql.ExecuteReader();

                     List<string> listaproducto = new List<string>();

                     while (dre.Read())
                     {
                         listaproducto.Add(dre[0].ToString());

                     }
                     listaproducto = listaproducto.ToList();
            /* this.con.Close(); */
            dre.Close();
                     this.Sql = string.Format(@"Select cantidad FROM PEDIDO where id_pedido='" + idpedido + "'");
                     this.ComSql = new SqlCommand(this.Sql, this.con);
                     /*this.con.Open();*/
                     SqlDataReader drr = ComSql.ExecuteReader();

                     List<string> listacantidad = new List<string>();

                     while (drr.Read())
                     {
                         listacantidad.Add(drr[0].ToString());

                     }
                     listacantidad = listacantidad.ToList();
            /* this.con.Close();*/
            drr.Close();
            int x = listaproducto.Count();
            for (int cont = 0; cont < x; cont++)
            {
                this.Sql = string.Format("UPDATE PRODUCTO SET stock = stock + @sto where id_producto=@idprod");
                this.ComSql = new SqlCommand(this.Sql, this.con);
                /*this.con.Open();*/
                int idprodd = Convert.ToInt32(listaproducto[cont]);
                int cantidad_lista = Convert.ToInt32(listacantidad[cont]);

                ComSql.Parameters.Add(new SqlParameter("@idprod", idprodd));
                ComSql.Parameters.Add(new SqlParameter("@sto", cantidad_lista));
                SqlDataReader Reg1 = null;
                Reg1 = this.ComSql.ExecuteReader();
                Reg1.Close();
                MessageBox.Show("Producto añadido al inventario ");

                     } 
            this.con.Close();

            idfactext.Text = "";
            combopedido.Text = "";
            Clientecombo.Text = "";
            totaltext.Text = "";
            fecha.Text = "";
            subtext.Text = "";
            formpatext.Text = "";


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

        private void combopedido_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
