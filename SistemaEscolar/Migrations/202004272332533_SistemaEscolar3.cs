namespace SistemaEscolar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaEscolar3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmas", "CargaHoraria", c => c.String(unicode: false));
            DropColumn("dbo.Cursos", "CargaHoraria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursos", "CargaHoraria", c => c.String(unicode: false));
            DropColumn("dbo.Turmas", "CargaHoraria");
        }
    }
}
