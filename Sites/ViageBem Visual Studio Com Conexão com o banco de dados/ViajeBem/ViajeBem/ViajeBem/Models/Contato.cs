using System.ComponentModel.DataAnnotations;

namespace ViajeBem.Models
{
    public class Contato
    {
        [Key]
        public int Id_Contato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Destino { get; set; }
        public string Mensagem { get; set; }



    }
}
