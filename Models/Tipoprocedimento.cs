using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Tipoprocedimento")]
    public class Tipoprocedimento
    {
        [Column("Id")]
        [Display(Name = "Cód. Tipoprocedimento")]
        public int Id { get; set; }

        [Column("TipoprocedimentoNome")]
        [Display(Name = "Nome Tipoprocedimento")]
        public string TipoprocedimentoNome { get; set; } = string.Empty;
    }
}
//okay
