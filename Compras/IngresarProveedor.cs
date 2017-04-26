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
    public partial class IngresarProveedor : Form

    {
        public string cadenaconexion;
        public string Sql;
        protected SqlConnection con;
        protected SqlCommand ComSql;
        public IngresarProveedor()
        {
            this.cadenaconexion = (@"Data Source=.; Initial Catalog= COMPRAS; Integrated security=true");
            this.con = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format("INSERT INTO PROVEEDOR(id_proveedor, nombre, telefono, email, direccion, rfc, codigo_postal) VALUES(@id,@nombre,@telefono,@email,@direccion,@rfc,@cod_postal)");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();

            int idprove = Convert.ToInt32(IDTextBox.Text);
            int telefono = Convert.ToInt32(TelefonoTextBox.Text);
            int cod_postal = Convert.ToInt32(CodigoPostalTextBox.Text);


            ComSql.Parameters.Add(new SqlParameter("@id", idprove));
            ComSql.Parameters.Add(new SqlParameter("@nombre", NombreTextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@telefono", telefono));
            ComSql.Parameters.Add(new SqlParameter("@email", CorreoTextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@direccion", DireccionTextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@rfc", RFCTextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@cod_postal", cod_postal));

            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            MessageBox.Show("Agregado al inventario!");
            this.Close();

        }
    }
}
