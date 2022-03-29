using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeBem.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }

       
        public string NomeCliente { get; set; }

        public string TelefoneCliente { get; set; }

        public string EmailCliente { get; set; }

        [ForeignKey("Destino")]
        public int Id_Destino_Cliente { get; set; }

        public virtual Destino destino { get; set; }




    }
}
