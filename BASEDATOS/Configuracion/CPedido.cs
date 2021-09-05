using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASEDATOS.Configuracion
{
    public class CPedido : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(e => e.IdPedido);

            builder.ToTable("pedido");

            builder.Property(e => e.IdPedido).HasColumnName("idPedido");

            builder.Property(e => e.Codigo)
                .IsRequired()
                .HasColumnName("codigo");

            builder.Property(e => e.Fecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha");

            builder.Property(e => e.IdCliente).HasColumnName("idCliente");

            builder.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pedido_cliente");
        }
    }
}
