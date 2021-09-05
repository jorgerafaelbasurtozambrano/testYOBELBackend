using AutoMapper;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASEDATOS.MAPPING
{
    public class PedidoMapping:Profile
    {
        public PedidoMapping()
        {
            CreateMap<Pedido, PedidoDTO>();
            CreateMap<PedidoDTO, Pedido>();

            CreateMap<PedidoDTOGestion, Pedido>();
            
        }
    }
}
