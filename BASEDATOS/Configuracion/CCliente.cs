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
    public class CCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.IdCliente);

            builder.ToTable("cliente");

            builder.Property(e => e.IdCliente).HasColumnName("idCliente");

            builder.Property(e => e.Dni)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("dni");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre");
        }
    }
}
