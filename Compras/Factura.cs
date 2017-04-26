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

        public int id_proveedor {
            get { return this.id_proveedor; }
            set { this.id_proveedor = value; }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'provedor_idDataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.provedor_idDataSet.PROVEEDOR);

        }

        private void Clientecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Sql = string.Format(@"Select * FROM registro_mp WHERE id_proveedor='{0}'", this.id_proveedor);
            this.ComSql = new SqlCommand(this.Sql, this.con);
            this.con.Open();


        }
    }
}
