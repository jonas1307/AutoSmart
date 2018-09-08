using System;

namespace AutoSmart.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }

        public bool PessoaFisica { get; set; }

        public string CpfCnpj { get; set; }

        public string TelefoneContato { get; set; }
    }
}
