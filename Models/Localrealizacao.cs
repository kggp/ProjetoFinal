using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Localrealizacao")]
    public class Localrealizacao
    {
        [Column("Id")]
        [Display(Name = "Cód. Localrealizacao")]
        public int Id { get; set; }

        [Column("Localrealizacaonome")]
        [Display(Name = "Nome Localrealizacao")]
        public string LocalrealizacaoNome { get; set; } = string.Empty;

        [ForeignKey("LocalrealizacaoId")]
        public int CidadeId { get; set; }

        public Cidade ? Cidade { get; set; }
    }
}
//okay
