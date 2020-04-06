namespace CRUD_com_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pessoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Pessoas");
        }
    }
}
