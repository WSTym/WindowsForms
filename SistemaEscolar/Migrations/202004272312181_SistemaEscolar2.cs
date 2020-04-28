namespace SistemaEscolar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaEscolar2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursos", "CargaHoraria", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cursos", "CargaHoraria", c => c.Int(nullable: false));
        }
    }
}
