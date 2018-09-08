using System;

namespace AutoSmart.Domain.Entities
{
    public class EntityBase
    {
        public long Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
