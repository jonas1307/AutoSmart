using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace AutoSmart.Infrastructure.Data.Context
{
    public class AutoSmartContext : DbContext
    {
        #region Constructors

        public AutoSmartContext()
            : base("AutoSmart")
        { }

        #endregion

        #region Properties
        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // remove pluralizing and cascade deletion conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // string properties
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("VARCHAR"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(255));

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Property("DataCadastro").IsModified = false;
                        break;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataModificacao") != null))
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataModificacao").IsModified = true;
                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        #endregion
    }
}
