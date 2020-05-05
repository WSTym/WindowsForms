namespace SistemaEscolar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SisEscolar : DbMigration
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
                .ForeignKey("dbo.Avaliacoes", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Avaliacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tema = c.String(maxLength: 50, storeType: "nvarchar"),
                        Valor = c.String(maxLength: 5, storeType: "nvarchar"),
                        Data = c.String(unicode: false),
                        DisciplinaId = c.Int(nullable: false),
                        Disciplina_Id = c.Int(),
                        Aluno_Id = c.Int(),
                        Curso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplinas", t => t.Disciplina_Id)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .ForeignKey("dbo.Alunos", t => t.Aluno_Id)
                .ForeignKey("dbo.Cursos", t => t.Curso_Id)
                .Index(t => t.DisciplinaId)
                .Index(t => t.Disciplina_Id)
                .Index(t => t.Aluno_Id)
                .Index(t => t.Curso_Id);
            
            CreateTable(
                "dbo.Disciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30, storeType: "nvarchar"),
                        CargaHoraria = c.String(maxLength: 4, storeType: "nvarchar"),
                        AulasSemanais = c.String(maxLength: 2, storeType: "nvarchar"),
                        TurmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Avaliacoes", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30, storeType: "nvarchar"),
                        Descricao = c.String(maxLength: 200, storeType: "nvarchar"),
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
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ano = c.String(maxLength: 4, storeType: "nvarchar"),
                        Turno = c.String(unicode: false),
                        CargaHoraria = c.String(maxLength: 4, storeType: "nvarchar"),
                        Semestre = c.String(maxLength: 2, storeType: "nvarchar"),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.CursoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turmas", "CursoId", "dbo.Cursos");
            DropForeignKey("dbo.Professores", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Notas", "IdAvaliacao", "dbo.Avaliacoes");
            DropForeignKey("dbo.Notas", "IdAluno", "dbo.Alunos");
            DropForeignKey("dbo.Avaliacoes", "Curso_Id", "dbo.Cursos");
            DropForeignKey("dbo.Alunos", "TurmaId", "dbo.Avaliacoes");
            DropForeignKey("dbo.Avaliacoes", "Aluno_Id", "dbo.Alunos");
            DropForeignKey("dbo.Avaliacoes", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Disciplinas", "TurmaId", "dbo.Avaliacoes");
            DropForeignKey("dbo.Avaliacoes", "Disciplina_Id", "dbo.Disciplinas");
            DropIndex("dbo.Turmas", new[] { "CursoId" });
            DropIndex("dbo.Professores", new[] { "DisciplinaId" });
            DropIndex("dbo.Notas", new[] { "IdAvaliacao" });
            DropIndex("dbo.Notas", new[] { "IdAluno" });
            DropIndex("dbo.Disciplinas", new[] { "TurmaId" });
            DropIndex("dbo.Avaliacoes", new[] { "Curso_Id" });
            DropIndex("dbo.Avaliacoes", new[] { "Aluno_Id" });
            DropIndex("dbo.Avaliacoes", new[] { "Disciplina_Id" });
            DropIndex("dbo.Avaliacoes", new[] { "DisciplinaId" });
            DropIndex("dbo.Alunos", new[] { "TurmaId" });
            DropTable("dbo.Turmas");
            DropTable("dbo.Professores");
            DropTable("dbo.Notas");
            DropTable("dbo.Cursos");
            DropTable("dbo.Disciplinas");
            DropTable("dbo.Avaliacoes");
            DropTable("dbo.Alunos");
        }
    }
}
