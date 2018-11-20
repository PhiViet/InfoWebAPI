namespace InfoWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Infoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstname = c.String(),
                        lastname = c.String(),
                        gender = c.String(),
                        role = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Infoes");
        }
    }
}
