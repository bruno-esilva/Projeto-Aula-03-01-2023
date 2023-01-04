using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Exercicio_03_01_23.Models
{
    [Table("configuracoes")]
    public class Configuracao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Dias de Locação")]
        [Column("diasLocacao", TypeName = "int")]
        public int DiasLocacao { get; set; }

    }
}
