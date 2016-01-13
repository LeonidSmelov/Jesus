namespace DanWithLeo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lalka : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusicRecs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Leanth = c.Double(nullable: false),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OnlineStores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OnlineStores");
            DropTable("dbo.MusicRecs");
        }
    }
}
