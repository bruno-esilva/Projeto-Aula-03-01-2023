using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Exercicio_03_01_23.Models
{
    [Table("pedidos")]
    public record Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Id Cliente")]
        [Column("idcliente", TypeName = "int")]
        public int IdCliente { get; set; }

        [Display(Name = "Carro")]
        [Column("carro", TypeName = "varchar(100)")]
        public string Carro { get; set; }

        [Display(Name = "Data de Locação")]
        [Column("dataLocacao", TypeName = "datetime")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DataLocacao { get; set; }

        [Display(Name = "Data de Entrega")]
        [Column("dataEntrega", TypeName = "datetime")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DataEntrega { get; set; }

    }
}
