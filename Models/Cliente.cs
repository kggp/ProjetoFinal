using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Cód. Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome Cliente")]
        public string ClienteNome { get; set; } = string.Empty;


        [Column("ClienteCpf")]
        [Display(Name = "Cpf Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteSexo")]
        [Display(Name = "Sexo Cliente")]
        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereço")]
        [Display(Name = "Endereço Cliente")]
        public string ClienteEndereço { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Numero Cliente")]
        public string ClienteNumero { get; set; } = string.Empty;


        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}

//okay