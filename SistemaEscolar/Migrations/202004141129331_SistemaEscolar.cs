namespace SistemaEscolar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SistemaEscolar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricula = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        Nome = c.String(maxLength: 50, storeType: "nvarchar"),
                        DataNascimento = c.String(unicode: false),
                        Edereco = c.String(maxLength: 50, storeType: "nvarchar"),
                        Telefone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turmas", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Avaliacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 50, storeType: "nvarchar"),
                        Valor = c.Single(nullable: false),
                        Data = c.String(unicode: false),
                        Falta = c.Boolean(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                        AlunoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunos", t => t.AlunoId, cascadeDelete: true)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .Index(t => t.DisciplinaId)
                .Index(t => t.AlunoId);
            
            CreateTable(
                "dbo.Disciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30, storeType: "nvarchar"),
                        TurmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turmas", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ano = c.Int(nullable: false),
                        CargaHoraria = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30, storeType: "nvarchar"),
                        CargaHoaria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacitacao = c.String(maxLength: 30, storeType: "nvarchar"),
                        DisciplinaId = c.Int(nullable: false),
                        Nome = c.String(maxLength: 50, storeType: "nvarchar"),
                        DataNascimento = c.String(unicode: false),
                        Edereco = c.String(maxLength: 50, storeType: "nvarchar"),
                        Telefone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professores", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Alunos", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.Avaliacoes", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Disciplinas", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.Turmas", "CursoId", "dbo.Cursos");
            DropForeignKey("dbo.Avaliacoes", "AlunoId", "dbo.Alunos");
            DropIndex("dbo.Professores", new[] { "DisciplinaId" });
            DropIndex("dbo.Turmas", new[] { "CursoId" });
            DropIndex("dbo.Disciplinas", new[] { "TurmaId" });
            DropIndex("dbo.Avaliacoes", new[] { "AlunoId" });
            DropIndex("dbo.Avaliacoes", new[] { "DisciplinaId" });
            DropIndex("dbo.Alunos", new[] { "TurmaId" });
            DropTable("dbo.Professores");
            DropTable("dbo.Cursos");
            DropTable("dbo.Turmas");
            DropTable("dbo.Disciplinas");
            DropTable("dbo.Avaliacoes");
            DropTable("dbo.Alunos");
        }
    }
}
