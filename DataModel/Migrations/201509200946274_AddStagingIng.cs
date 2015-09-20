namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStagingIng : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.stgING",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.Int(nullable: false),
                        Naam = c.String(),
                        Rekening = c.String(),
                        Tegenrekening = c.String(),
                        Code = c.String(),
                        AfBij = c.String(),
                        Bedrag = c.String(),
                        MutatieSoort = c.String(),
                        Mededelingen = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.stgING");
        }
    }
}
