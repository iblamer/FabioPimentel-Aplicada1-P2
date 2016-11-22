using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAL;
using BLL;

namespace FabioPimentel_Apliacada1_P2
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private Clientes client = new Clientes();

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            LLenaCombo();
        }


        private void LLenaCombo()
        {
            TelefonoscomboBox.DataSource = TiposTelefonosBLL.GetLista();
            TelefonoscomboBox.DisplayMember = "Descripcion";
            TelefonoscomboBox.ValueMember = "TipoId";
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            client.Telefonos.Add(new TiposTelefonos((int)TelefonoscomboBox.SelectedValue, TelefonoscomboBox.Text));
            TelefonosdataGridView.DataSource = null;
            TelefonosdataGridView.DataSource = client.Telefonos;
        }

        private void LlenarClases(Clientes cliente)
        {
            cliente.Nombres = NombretextBox.Text;
            cliente.FechaNacimiento = Convert.ToDateTime(FechadateTimePicker.Text);
            cliente.LimiteCredito = float.Parse(LimiteCreditotextBox.Text);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (Search())
            {
                Fill(ClientesBll.Buscar(StringToInt(IdtextBox.Text)));
                TelefonosdataGridView.DataSource = null;
                TelefonosdataGridView.DataSource = client.Telefonos;
            }
        }

        private bool Search()
        {
            if (ClientesBll.Buscar(StringToInt(IdtextBox.Text)) == null)
            {
                MessageBox.Show("El Id no existe");
                return false;
            }

            return true;
        }

        private int StringToInt(string s)
        {
            int n = 0;

            int.TryParse(s, out n);

            return n;
        }

        private void Fill(Clientes cliente)
        {
            NombretextBox.Text = cliente.Nombres;
            FechadateTimePicker.Text = cliente.FechaNacimiento.ToString();
            LimiteCreditotextBox.Text = cliente.LimiteCredito.ToString();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            LlenarClases(cliente);

            if (ClientesBll.Insertar(cliente))
            {
                MessageBox.Show("Se guardo el cliente");
                clean();
            }
            else
                MessageBox.Show("Error al guardar el cliente");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Search())
            {
                ClientesBll.Borrar(StringToInt(IdtextBox.Text));
                MessageBox.Show("Se borro el cliente");
                clean();
            }

        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            LlenarClases(cliente);

            ClientesBll.Modificar(StringToInt(IdtextBox.Text), cliente);

            MessageBox.Show("Se modifico el usuario");
            clean();

        }

        private void clean()
        {
            NombretextBox.Clear();
            LimiteCreditotextBox.Clear();
        }
    }
}
