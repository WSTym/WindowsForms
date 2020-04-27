namespace SistemaEscolar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaEscolar1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmas", "Turno", c => c.String(unicode: false));
            AddColumn("dbo.Turmas", "Semestre", c => c.Int(nullable: false));
            AddColumn("dbo.Cursos", "CargaHoraria", c => c.Int(nullable: false));
            DropColumn("dbo.Turmas", "Horario");
            DropColumn("dbo.Cursos", "CargaHoaria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursos", "CargaHoaria", c => c.Int(nullable: false));
            AddColumn("dbo.Turmas", "Horario", c => c.String(unicode: false));
            DropColumn("dbo.Cursos", "CargaHoraria");
            DropColumn("dbo.Turmas", "Semestre");
            DropColumn("dbo.Turmas", "Turno");
        }
    }
}
