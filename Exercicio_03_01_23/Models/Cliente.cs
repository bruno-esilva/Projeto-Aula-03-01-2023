using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio_03_01_23.Models

{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome", TypeName = "varchar(100)")]
        public string? Nome { get; set; }
         
        [Display(Name = "Endereço")]
        [Column("endereco", TypeName = "varchar(200)")]
        public string? Endereco { get; set; }
        
        [Display(Name = "Telefone")]
        [Column("telefone", TypeName = "varchar(20)")]
        public string? Telefone { get; set; }

        [Display(Name = "Email")]
        [Column("email", TypeName = "varchar(150)")]
        public string? Email { get; set; }
        
    }
}

