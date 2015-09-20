namespace Administration.DataModel
{
    using System.Data.Entity;

    public class AdministrationContext : DbContext
    {
        public AdministrationContext()
        {
            // Add some context settings here
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
