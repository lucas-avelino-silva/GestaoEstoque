using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppMVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [HiddenInput]
        public Guid FornecedorId { get; set; }

        
        [StringLength(200, ErrorMessage ="O campo {0} precisa ter entre {2} e {1}.", MinimumLength =2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio.")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter entre {2} e {1}.", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(8, ErrorMessage ="O campo {0} deve ter {2} caracteres.", MinimumLength =8)]
        public string Cep { get; set; }

        [Required(ErrorMessage ="O campo é obrigatório.")]
        [StringLength(100, ErrorMessage ="O {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.", MinimumLength =2)]
        public string Estado { get; set; }

        /* EF Relation */
        public FornecedorViewModel Fornecedor { get; set; }
    }
}
