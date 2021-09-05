using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IPedido
    {
        Task<IEnumerable<Pedido>> GetPedidos();
        Task<Pedido> IngresarPedidos(Pedido pedido);
        Task<Pedido> ModificarPedidos(Pedido pedido);
        Task<string> EliminarPedidos(int idPedido);
    }
}
