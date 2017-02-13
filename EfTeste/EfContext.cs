using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfTeste.Mappings;
using EfTeste.Models;

namespace EfTeste
{
    public class EfContext: DbContext
    {
        public EfContext()
            :base("Name=DefaultConnection")
        {
            Database.Initialize(false);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<DocumentoTipo> DocumentosTipos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(x=>x.HasColumnType("varchar").HasMaxLength(50));

            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new DocumentoMap());
            modelBuilder.Configurations.Add(new DocumentoTipoMap());

        }
    }
}
