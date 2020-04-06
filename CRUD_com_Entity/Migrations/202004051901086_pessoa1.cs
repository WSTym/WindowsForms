namespace CRUD_com_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pessoa1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(maxLength: 50, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(unicode: false));
        }
    }
}
