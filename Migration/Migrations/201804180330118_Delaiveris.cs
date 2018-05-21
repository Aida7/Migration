namespace Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delaiveris : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Addres = c.String(),
                    BookId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "BookId", "dbo.Books");
            DropIndex("dbo.Deliveries", new[] { "BookId" });
            DropTable("dbo.Deliveries");
        }
    }
}
