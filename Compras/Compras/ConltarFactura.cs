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
    public partial class ConltarFactura : Form
    {

        public string cadenaconexion;
        public string Sql;
        protected SqlConnection con;
        protected SqlCommand ComSql;
        public ConltarFactura()
        {
            this.cadenaconexion = (@"Data Source=.; Initial Catalog= COMPRAS; Integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        public void carga()
        {

            this.con.Open();
            this.Sql = string.Format("SELECT * FROM PRODUCTO");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewfacturac.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

        }

        private void ConltarFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturaDataSet.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.facturaDataSet.FACTURA);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarconsfacboton_Click(object sender, EventArgs e)
        {

            this.con.Open();
            this.Sql = string.Format("SELECT * FROM FACTURA where id_factura='" + id_factext.Text + "'");
            this.ComSql = new SqlCommand(Sql, con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ComSql);
            da.Fill(dt);
            dataGridViewfacturac.DataSource = dt;
            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            this.con.Close();

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
