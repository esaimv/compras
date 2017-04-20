using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
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
    }
}
