using System;
using BASEDATOS.Configuracion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Negocio.Entidades;

#nullable disable

namespace BASEDATOS.Data
{
    public partial class yobelscmBDContext : DbContext
    {
        public yobelscmBDContext()
        {

        }

        public yobelscmBDContext(DbContextOptions<yobelscmBDContext> options)
                    : base(options)
        {
            
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CCliente());
            modelBuilder.ApplyConfiguration(new CPedido());
        }
    }
}
