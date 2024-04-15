using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rastreador.Models
{
    public class Users
    {
        [Key]
        [Column("UserID")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email do usuário é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email do usuário não é válido.")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha do usuário é obrigatória.")]
        [Column("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "O TipoID do usuário é obrigatório.")]
        [Column("TipoID")]
        public int TipoID { get; set; }

        [ForeignKey("TipoID")]
        public TipoUser TipoUser { get; set; }
    }
}