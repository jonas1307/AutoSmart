using System;
using System.ComponentModel.DataAnnotations;

namespace AutoSmart.Application.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Id = 0;
            PessoaFisica = true;
            DataCriacao = null;
        }

        [Key]
        public long Id { get; set; }

        [Display(Name = "Nome:")]
        [MinLength(3, ErrorMessage = "Digite ao menos {1} caracteres.")]
        [MaxLength(255, ErrorMessage = "É permitido até {1} caracteres.")]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Nome { get; set; }

        public bool PessoaFisica { get; set; }

        [Display(Name = "CPF/CNPJ:")]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string CpfCnpj { get; set; }

        [Display(Name = "Telefone:")]
        [MaxLength(14, ErrorMessage = "É permitido até {1} caracteres.")]
        public string TelefoneContato { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Criação:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? DataCriacao { get; set; }
    }
}
