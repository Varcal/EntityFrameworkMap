using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfTeste.Models;

namespace EfTeste.Mappings
{
    public class DocumentoTipoMap: EntityTypeConfiguration<DocumentoTipo>
    {
        public DocumentoTipoMap()
        {
            ToTable("DocumentoTipo");

            HasKey(p => p.Id);

            Property(p => p.Nome).IsRequired();
        }
    }
}
