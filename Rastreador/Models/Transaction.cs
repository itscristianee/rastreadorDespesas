namespace Rastreador.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Transaction
    {
        [Key]
        public int ID_Transacao { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "A data é obrigatória")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "O ID da categoria é obrigatório")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que 0")]
        public decimal Amount { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "O tipo de transação é obrigatório")]
        public string Tipo { get; set; }

        // Propriedade de navegação para a categoria
        public Category? Category { get; set; }

       
    }
}