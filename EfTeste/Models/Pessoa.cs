using System.Collections.Generic;

namespace EfTeste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Documento> Documentos { get; set; }
    }
}
