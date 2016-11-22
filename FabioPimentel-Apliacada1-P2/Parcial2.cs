using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FabioPimentel_Apliacada1_P2
{
    public partial class Parcial2 : Form
    {
        public Parcial2()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes rClientes = new RegistroClientes();
            rClientes.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes cClientes = new ConsultaClientes();
            cClientes.Show();
        }
    }
}
