using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rastreador.Models
{
    public class Category
    {
        [Key]
        [Column("CategoryID")] // Define o nome da coluna na tabela
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "O título da categoria é obrigatório.")]
        [Column("Name")] // Define o nome da coluna na tabela
        public string Title { get; set; }
    }
}