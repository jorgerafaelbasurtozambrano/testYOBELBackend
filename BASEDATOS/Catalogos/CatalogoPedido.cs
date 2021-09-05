using BASEDATOS.Data;
using Microsoft.EntityFrameworkCore;
using Negocio.Entidades;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASEDATOS.Catalogos
{
    public class CatalogoPedido : IPedido
    {
        private readonly yobelscmBDContext context;
        public CatalogoPedido(yobelscmBDContext _context)
        {
            context = _context;
        }

        public async Task<string> EliminarPedidos(int idPedido)
        {
            Pedido pedido = context.Pedidos.First(x => x.IdPedido == idPedido);
            context.Pedidos.Remove(pedido);
            context.SaveChanges();
            return "Eliminado correctamente";
        }

        public async Task<IEnumerable<Pedido>> GetPedidos()
        {
            return await context.Pedidos.Include(p=>p.IdClienteNavigation).ToListAsync();
        }

        public async Task<Pedido> IngresarPedidos(Pedido pedido)
        {
            await context.Pedidos.AddAsync(pedido);
            await context.SaveChangesAsync();
            return pedido;
        }

        public async Task<Pedido> ModificarPedidos(Pedido pedido)
        {
            context.Entry(await context.Pedidos.FirstOrDefaultAsync(e => e.IdPedido == pedido.IdPedido)).CurrentValues.SetValues(pedido);
            //var result = context.Pedidos.SingleOrDefault(e => e.IdPedido == pedido.IdPedido);
            //result = pedido;
            await context.SaveChangesAsync();
            return pedido;
        }
    }
}
