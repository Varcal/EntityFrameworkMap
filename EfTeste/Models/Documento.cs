namespace EfTeste.Models
{
    public class Documento
    {
        public int Id { get; set; }
        public int DocumentoTipoId { get; set; }
        public string Numero { get; set; }
        public DocumentoTipo DocumentoTipo { get; set; }
    }
}