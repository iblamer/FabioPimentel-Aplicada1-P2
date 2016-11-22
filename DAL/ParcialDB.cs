using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class ParcialDb : DbContext
    {
        public ParcialDb() : base("name=ConStr")
        {

        }

        public virtual DbSet<Clientes> Cliente { set; get; }
        public virtual DbSet<TiposTelefonos> TipoTelefono { get; set; }
        public virtual DbSet<ClientesTelefonos> ClienteTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .HasMany(c => c.Telefonos)
                .WithMany(t=> t.Clientes)
                .Map(ct =>
                {
                    ct.MapLeftKey("ClientesId");
                    ct.MapRightKey("TipoId");
                    ct.ToTable("ClientesTelefonos");
                });
        }
    }
}
