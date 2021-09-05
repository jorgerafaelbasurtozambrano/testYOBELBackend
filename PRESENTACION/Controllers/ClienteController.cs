using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTACION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ICliente cliente;
        public ClienteController(ICliente _cliente)
        {
            cliente = _cliente;
        }
        [HttpGet]
        public async Task<IActionResult> getCliente()
        {
            var personas = await cliente.GetClientes();
            return Ok(personas);
        }
    }
}
