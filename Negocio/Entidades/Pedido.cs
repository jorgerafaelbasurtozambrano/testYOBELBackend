using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
