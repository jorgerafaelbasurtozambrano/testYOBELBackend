using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface ICliente
    {
        Task<IEnumerable<Cliente>> GetClientes();
    }
}
