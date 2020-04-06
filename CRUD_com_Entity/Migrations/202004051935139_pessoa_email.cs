namespace CRUD_com_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pessoa_email : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Email", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Email");
        }
    }
}
