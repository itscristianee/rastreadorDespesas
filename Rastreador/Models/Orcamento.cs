using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rastreador.Models
{
    public class Orcamento
    {
        [Key]
        [Column("ID_Orcamento")]
        public int ID_Orcamento { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        [Column("UserID")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "O mês é obrigatório.")]
        [Column("Mes")]
        public DateTime Mes { get; set; }

        [Column("Meta_Despesas")]
        public decimal? Meta_Despesas { get; set; }

        [Column("Meta_Entradas")]
        public decimal? Meta_Entradas { get; set; }

        [ForeignKey("UserID")]
        public Users User { get; set; }
    }
}