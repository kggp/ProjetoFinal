using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Cód. Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Estado")]
        public string EstadoNome { get; set; } = string.Empty;
    }
}
//okay
