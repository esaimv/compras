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
            // TODO: esta línea de código carga datos en la tabla 'tablaPedidoDataSet.PEDIDO' Puede moverla o quitarla según sea necesario.
            this.pEDIDOTableAdapter.Fill(this.tablaPedidoDataSet.PEDIDO);
            // TODO: esta línea de código carga datos en la tabla 'descProdDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.descProdDataSet.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'nomProvedorDataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.nomProvedorDataSet.PROVEEDOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sql = string.Format("INSERT INTO PEDIDO(precio_unitario, cantidad, medida, descripcion, importe, id_factura, id_producto, id_empleado, id_proveedor) VALUES(@precio,@cantidad,@medida,@descr,@importe,@id_factura,@id_producto,@id_empleado, @id_proveedor)");
            this.ComSql = new SqlCommand(Sql, con);
            this.con.Open();


            double precio = Convert.ToDouble(preciountext.Text);
            int cant = Convert.ToInt32(canttext.Text);
            double importe = Convert.ToDouble(Importtext.Text);

            ComSql.Parameters.Add(new SqlParameter("@precio", precio));
            ComSql.Parameters.Add(new SqlParameter("@cantidad", cant));
            ComSql.Parameters.Add(new SqlParameter("@medida", medtext.Text));
            ComSql.Parameters.Add(new SqlParameter("@descr", DesctextBox.Text));
            ComSql.Parameters.Add(new SqlParameter("@importe", importe));

            SqlDataReader Reg = null;
            Reg = this.ComSql.ExecuteReader();
            MessageBox.Show("Agregado al inventario!");
            this.con.Close();

        }
    }
}
