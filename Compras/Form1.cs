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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
