using System.ComponentModel.DataAnnotations;

namespace ViajeBem.Models
{
    public class Destino
    {
        [Key]
        public int Id_Destino_Cliente { get; set; }
        public string NomeDestino { get; set; }
        public string Pais { get; set; }
        public DateTime DataViagem { get; set; }

        public virtual List<Cliente> clientes { get; set; }
    }
}
