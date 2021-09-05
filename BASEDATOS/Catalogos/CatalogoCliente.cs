using BASEDATOS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Interfaces;
using Negocio.Entidades;
using Microsoft.EntityFrameworkCore;
namespace BASEDATOS
{
    public class CatalogoCliente:ICliente
    {
        private readonly yobelscmBDContext context;
        public CatalogoCliente(yobelscmBDContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await context.Clientes.ToListAsync();
        }
    }
}
