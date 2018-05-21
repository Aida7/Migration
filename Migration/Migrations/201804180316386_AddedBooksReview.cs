namespace Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBooksReview : DbMigration
    {
        public override void Up()
        {
            Down();
            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Autor = c.String(),
                    Price = c.Double(nullable: false),
                    Review = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
