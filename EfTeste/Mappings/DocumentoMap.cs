using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfTeste.Models;

namespace EfTeste.Mappings
{
    public class DocumentoMap: EntityTypeConfiguration<Documento>
    {
        public DocumentoMap()
        {
            ToTable("Documento");

            HasKey(p => p.Id);

            HasRequired(p => p.DocumentoTipo)
                .WithMany()
                .HasForeignKey(fk => fk.DocumentoTipoId);

            Property(p => p.Numero).IsRequired();
            Property(p => p.DocumentoTipoId).IsRequired();
        }
    }
}
