using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ClientesBll
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;

            try
            {
                ClientesDb db = new ClientesDb();
                db.Clientes.Add(cliente);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                using (ClientesDb db = new ClientesDb())
                {
                    Clientes user = (from c in db.Clientes where c.clienteID == id select c).FirstOrDefault();
                    db.Clientes.Remove(user);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static bool Editar(int id,string nombre,string fecha, int credito)
        {
            bool retorno = false;
            try
            {
                using (ClientesDb db = new ClientesDb())
                {
                    Clientes cliente = (from c in db.Clientes where c.clienteID == id select c).FirstOrDefault();
                    cliente.nombre = nombre;
                    cliente.fecha = fecha;
                    cliente.limiteCredito = credito;
                    db.SaveChanges();

                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            ClientesDb db = new ClientesDb();

            lista = db.Clientes.ToList();
            return lista;
        }

        public static List<Clientes> GetLista(string nombre)
        {
            List<Clientes> lista = new List<Clientes>();
            ClientesDb  db = new ClientesDb();

            lista = db.Clientes.Where(u => u.nombre== nombre).ToList();
            return lista;
        }
    }
}
