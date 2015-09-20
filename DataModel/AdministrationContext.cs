namespace Administration.DataModel
{
    using System.Data.Entity;
    using Models;
    using Models.Mappings;

    public class AdministrationContext : DbContext
    {
        public AdministrationContext()
        {
            // Add some context settings here
        }

        public DbSet<StagingIng> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new StagingIngMap());
        }
    }
}
