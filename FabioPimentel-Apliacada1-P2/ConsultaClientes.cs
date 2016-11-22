using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
using DAL;

namespace FabioPimentel_Apliacada1_P2
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        public List<Clientes> lista = new List<Clientes>();
        private void buscarButton_Click(object sender, EventArgs e)
        {
            if(FiltrocomboBox.SelectedIndex == 0)
            {
                lista = ClientesBll.GetLista(Convert.ToDateTime(DesdedateTimePicker) , Convert.ToDateTime(HastadateTimePicker));
            }
            if(FiltrocomboBox.SelectedIndex == 1)
            {
                lista = ClientesBll.GetLista(FiltrotextBox.Text);
            }

            if(FiltrocomboBox.SelectedIndex == 3)
            {
                lista = ClientesBll.GetLista();
            }

            if(FiltrocomboBox.SelectedIndex == 2)
            {
                lista = ClientesBll.GetLista(int.Parse(FiltrocomboBox.Text));
            }
            dataGridView1.DataSource = lista;

        }
    }
}
