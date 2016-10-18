using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int clienteID { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public int limiteCredito { get; set; }

    }
}
