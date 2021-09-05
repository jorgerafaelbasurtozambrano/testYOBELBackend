using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class PedidoDTOGestion
    {
        public int IdPedido { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
    }
}
