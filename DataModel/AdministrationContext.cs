namespace Administration.DataModel
{
    using Adminstration.DataModel.Models;
    using Mappings;
    using System.Data.Entity;

    public class AdministrationContext : DbContext
    {
        public AdministrationContext()
        {
            // Add some context settings here
        }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new TransactionMap());
        }
    }
}
