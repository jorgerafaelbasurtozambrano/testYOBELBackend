using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Negocio.Entidades;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTACION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private IPedido pedido;
        private readonly IMapper autoMapper;
        public PedidoController(IPedido _pedido, IMapper _autoMapper)
        {
            pedido = _pedido;
            autoMapper = _autoMapper;
        }
        [HttpGet]
        public async Task<IActionResult> getPedidos()
        {
            var personas = await pedido.GetPedidos();
            var response = autoMapper.Map<IEnumerable<PedidoDTO>>(personas);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> ingresarPedido(PedidoDTOGestion _pedido)
        {
            var response = autoMapper.Map<Pedido>(_pedido);
            var personas = await pedido.IngresarPedidos(response);
            return Ok(personas);
        }
        [HttpPut]
        public async Task<IActionResult> modificarPedido(PedidoDTOGestion _pedido)
        {
            var response = autoMapper.Map<Pedido>(_pedido);
            var personas = await pedido.ModificarPedidos(response);
            return Ok(personas);
        }
        [HttpDelete]
        public async Task<IActionResult> eliminarPedido(int idPedido)
        {
            var personas = await pedido.EliminarPedidos(idPedido);
            return Ok(personas);
        }
    }
}
