using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Tipocolaborador")]
    public class Tipocolaborador
    {
        [Column("Id")]
        [Display(Name = "Cód. Tipocolaborador")]
        public int Id { get; set; }

        [Column("TipocolaboradorNome")]
        [Display(Name = "Nome Tipocolaborador")]
        public string TipocolaboradorNome { get; set; } = string.Empty;
    }
}

//okay
