namespace Demo.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PriceInPence = c.Int(nullable: false),
                        Genre = c.String(),
                        Language = c.String(),
                        Length = c.Int(nullable: false),
                        TimeUpdated = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}
