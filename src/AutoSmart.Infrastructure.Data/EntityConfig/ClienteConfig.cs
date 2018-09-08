using System.Data.Entity.ModelConfiguration;
using AutoSmart.Domain.Entities;

namespace AutoSmart.Infrastructure.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("Clientes");

            HasKey(pk => pk.Id);

            Property(p => p.Nome)
                .IsRequired();

            Property(p => p.PessoaFisica)
                .IsRequired();

            Property(p => p.CpfCnpj)
                .IsRequired();

            Property(p => p.TelefoneContato)
                .HasMaxLength(15);

            Property(p => p.Email);

            Property(p => p.DataCriacao)
                .IsRequired();

            Property(p => p.DataAlteracao);
        }
    }
}