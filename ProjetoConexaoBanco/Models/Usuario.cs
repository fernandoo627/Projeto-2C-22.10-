using System.ComponentModel.DataAnnotations;

namespace ProjetoConexaoBanco.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int? idUsu { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo Nome Completo é obrigatório.")]
        public string nomeUsu { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O campo Cargo é obrigatório.")]
        public string cargo { get; set; }

        [Display(Name = ("Nascimento"))]
        [Required(ErrorMessage = "O campo Nascimento é obrigatório.")]
        [DataType(DataType.DateTime)]
        public DateTime dataNasc { get; set; }
    }

    
}
