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

        [MinLength(3)]
        [MaxLength(255)]
        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Nome { get; set; }

        public bool PessoaFisica { get; set; }

        [Display(Name = "CPF/CNPJ:")]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string CpfCnpj { get; set; }

        [MaxLength(14)]
        [Display(Name = "Telefone:")]
        public string TelefoneContato { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? DataCriacao { get; set; }
    }
}
