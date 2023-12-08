using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Procedimentorealizado
    {
        [Column("Id")]
        [Display(Name = "Cód. Procedimentorealizado")]
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalrealizacaoId")]
        public int? LocalrealizacaoId { get; set; }

        public Localrealizacao? Localrealizacao { get; set; }

        [Column("DatarealizacaoNome")]
        [Display(Name = "Nome Dtarealizacao")]
        public DateTime Datarealizacao { get; set; }

        [Column("ObservacaoRealizacaoNome")]
        [Display(Name = "Nome ObservacaoRealizacao")]
        public string ObservacaoRealizacaoNome { get; set; } = string.Empty;
    }
}

//okay
