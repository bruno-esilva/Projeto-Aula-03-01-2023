using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Exercicio_03_01_23.Models
{
    [Table("carros")]
    public class Carro
    {
        [Key]
        [Display(Name = "#")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        [Display(Name = "Marca")]
        public string? Marca { get; set; }
        [Display(Name = "Modelo")]
        public string? Modelo { get; set; }
    }
}
