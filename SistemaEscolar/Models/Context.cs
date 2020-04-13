using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace SistemaEscolar.Models.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public Context() : base("name=Conn") { }
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Avaliacao> avaliacoes { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Disciplina> disciplinas { get; set; }
        public DbSet<Professor> professores { get; set; }
        public DbSet<Turma> turmas { get; set; }
    }
}
