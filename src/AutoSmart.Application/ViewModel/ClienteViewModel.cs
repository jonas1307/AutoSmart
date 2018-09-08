using System;
using System.ComponentModel.DataAnnotations;

namespace AutoSmart.Application.ViewModel
{
    public class ClienteViewModel
    {
        [Key]
        public long Id { get; set; }

        [MinLength(3)]
        [MaxLength(255)]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Nome { get; set; }

        public bool PessoaFisica { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string CpfCnpj { get; set; }

        [MaxLength(14)]
        public string TelefoneContato { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DataCriacao { get; set; }
    }
}
