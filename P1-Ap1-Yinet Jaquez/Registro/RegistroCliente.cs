using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entidades;
using BLL;

namespace P1_Ap1_Yinet_Jaquez
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(nombreTexBox.Text) || String.IsNullOrEmpty(creditoTextBox.Text))
            {
                MessageBox.Show("Llene todos los campos ");

            }
            else
            {
                Clientes cl = new Clientes();
                
                cl.nombre = nombreTexBox.Text;
                cl.fecha = fechaTexBox.Text;
                cl.limiteCredito = Convert.ToInt32(creditoTextBox.Text);

                if (ClientesBll.Guardar(cl))
                {
                    MessageBox.Show("Guardado Exitosamente");
                }

                Limpiar();
            }
           
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.consultaClientes c = new Consultas.consultaClientes();
            c.Show();
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            ClientesBll.Eliminar(id);
            MessageBox.Show("Eliminado !");
            Limpiar();
        }
        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            if (string.IsNullOrEmpty(IDtextBox.Text))
            {
                MessageBox.Show("Tienes el campo vacio");
                Limpiar();
            }
            else
            {
                BuscarID();
            }
        }

        public void BuscarID()
        {
            int id = Convert.ToInt32(IDtextBox.Text);

            using (ClientesDb db = new ClientesDb())
            {
                try
                {
                    var name = (from c in db.Clientes
                                where c.clienteID == id
                                select c.nombre).FirstOrDefault();

                    var fecha = (from c in db.Clientes
                                  where c.clienteID== id
                                  select c.fecha).FirstOrDefault();

                    var limCredito = (from c in db.Clientes
                                      where c.clienteID == id
                                      select c.limiteCredito).FirstOrDefault();

                    nombreTexBox.Text = name;
                    fechaTexBox.Text = fecha;
                    creditoTextBox.Text = Convert.ToString(limCredito);

                    if (name == null || fecha == null)
                    {
                        MessageBox.Show("Este Usuario no esxiste");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Este usuario no existe");
                }

            }
        }

        private void ModificarBoton_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(IDtextBox.Text) || String.IsNullOrEmpty(nombreTexBox.Text) || String.IsNullOrEmpty(fechaTexBox.Text) || String.IsNullOrEmpty(creditoTextBox.Text))
            {
                MessageBox.Show("Complete los Campos");
            }
            else
            {
                int id = Convert.ToInt32(IDtextBox.Text);
                int credito = Convert.ToInt32(creditoTextBox.Text);
                string nombre = nombreTexBox.Text;
                string fecha = fechaTexBox.Text;

                    if (ClientesBll.Editar(id,nombre,fecha,credito))
                    {
                        MessageBox.Show("Usuario editado exitosamente");
                    }
                Limpiar();
            }
           
        }

        public void Limpiar()
        {
            IDtextBox.Clear();
            nombreTexBox.Clear();
            fechaTexBox.Clear();
            creditoTextBox.Clear();
        }
    }
}
