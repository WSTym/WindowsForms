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
                        CPF = c.String(maxLength: 14, storeType: "nvarchar"),
                        Edereco = c.String(maxLength: 50, storeType: "nvarchar"),
                        Telefone = c.String(maxLength: 20, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turmas", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Avaliacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tema = c.String(maxLength: 50, storeType: "nvarchar"),
                        Valor = c.Single(nullable: false),
                        Data = c.String(unicode: false),
                        DisciplinaId = c.Int(nullable: false),
                        Aluno_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .ForeignKey("dbo.Alunos", t => t.Aluno_Id)
                .Index(t => t.DisciplinaId)
                .Index(t => t.Aluno_Id);
            
            CreateTable(
                "dbo.Disciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30, storeType: "nvarchar"),
                        CargaHoraria = c.Int(nullable: false),
                        AulasSemanais = c.Int(nullable: false),
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
                        Horario = c.String(unicode: false),
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
                        Descricao = c.String(maxLength: 200, storeType: "nvarchar"),
                        CargaHoaria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Single(nullable: false),
                        Falta = c.Boolean(nullable: false),
                        IdAluno = c.Int(nullable: false),
                        IdAvaliacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunos", t => t.IdAluno, cascadeDelete: true)
                .ForeignKey("dbo.Avaliacoes", t => t.IdAvaliacao, cascadeDelete: true)
                .Index(t => t.IdAluno)
                .Index(t => t.IdAvaliacao);
            
            CreateTable(
                "dbo.Professores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacitacao = c.String(maxLength: 30, storeType: "nvarchar"),
                        DisciplinaId = c.Int(nullable: false),
                        Nome = c.String(maxLength: 50, storeType: "nvarchar"),
                        DataNascimento = c.String(unicode: false),
                        CPF = c.String(maxLength: 14, storeType: "nvarchar"),
                        Edereco = c.String(maxLength: 50, storeType: "nvarchar"),
                        Telefone = c.String(maxLength: 20, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professores", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Notas", "IdAvaliacao", "dbo.Avaliacoes");
            DropForeignKey("dbo.Notas", "IdAluno", "dbo.Alunos");
            DropForeignKey("dbo.Alunos", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.Avaliacoes", "Aluno_Id", "dbo.Alunos");
            DropForeignKey("dbo.Avaliacoes", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Disciplinas", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.Turmas", "CursoId", "dbo.Cursos");
            DropIndex("dbo.Professores", new[] { "DisciplinaId" });
            DropIndex("dbo.Notas", new[] { "IdAvaliacao" });
            DropIndex("dbo.Notas", new[] { "IdAluno" });
            DropIndex("dbo.Turmas", new[] { "CursoId" });
            DropIndex("dbo.Disciplinas", new[] { "TurmaId" });
            DropIndex("dbo.Avaliacoes", new[] { "Aluno_Id" });
            DropIndex("dbo.Avaliacoes", new[] { "DisciplinaId" });
            DropIndex("dbo.Alunos", new[] { "TurmaId" });
            DropTable("dbo.Professores");
            DropTable("dbo.Notas");
            DropTable("dbo.Cursos");
            DropTable("dbo.Turmas");
            DropTable("dbo.Disciplinas");
            DropTable("dbo.Avaliacoes");
            DropTable("dbo.Alunos");
        }
    }
}
