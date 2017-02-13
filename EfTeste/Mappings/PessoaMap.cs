using System.Data.Entity.ModelConfiguration;
using EfTeste.Models;

namespace EfTeste.Mappings
{
    public class PessoaMap: EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");

            HasKey(p => p.Id);

            HasMany(p => p.Documentos)
                .WithRequired()
                .Map(m =>
                {
                    m.MapKey("PessoaId");
                })
                .WillCascadeOnDelete(true);

            Property(p => p.Nome).IsRequired();
        }
    }
}
