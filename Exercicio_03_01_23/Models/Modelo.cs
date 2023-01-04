using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Exercicio_03_01_23.Models
{
    [Table("modelos")]
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome", TypeName = "varchar(100)")]
        public string? Nome { get; set; }
        
    }
}
