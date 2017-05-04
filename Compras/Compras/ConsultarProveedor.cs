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
    public partial class ConsultarProveedor : Form
    {
        public string cadenaconexion;
        public string Sql;
        protected SqlConnection con;
        protected SqlCommand ComSql;
        public ConsultarProveedor()
        {
            this.cadenaconexion = (@"Data Source=.; Initial Catalog= COMPRAS; Integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
           
            this.Sql = string.Format("DELETE FROM PROVEEDOR WHERE id_proveedor='"+IDTextBox.Text+"'");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();
            MessageBox.Show("Se borro ");
            carga();
        }

        public void carga() {

            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PROVEEDOR");
            this.ComSql = new SqlCommand(Sql, con);   

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewProvedores.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConsultarProveedor_Load(object sender, EventArgs e)
        {
            carga();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            IngresarProveedor i = new IngresarProveedor();
            i.Show();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            carga();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PROVEEDOR where id_proveedor='"+IDTextBox.Text+"'");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewProvedores.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProveedor consu = new ConsultarProveedor();
            consu.Show();
            this.Hide();
        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProveedor insert = new IngresarProveedor();
            insert.Show();
            this.Hide();
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 pedido = new Compras.Form1();
            pedido.Show();
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
