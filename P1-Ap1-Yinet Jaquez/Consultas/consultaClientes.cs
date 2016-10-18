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

namespace P1_Ap1_Yinet_Jaquez.Consultas
{
    public partial class consultaClientes : Form
    {
        public consultaClientes()
        {
            InitializeComponent();
        }

        List<Clientes> lista = new List<Clientes>();

        private void ConsultarBoton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(nombreTexBox.Text))
            {
                lista = ClientesBll.GetLista(nombreTexBox.Text);
            }
            else
            {
                lista = ClientesBll.GetLista();

            }
            listadoClientes.DataSource = lista;
        }
    }
}
