using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityTest
{
public class BancoContext:DbContext
    {
    public BancoContext() : base("name = connectionDB") { }

    public DbSet<Turma> Turmas { get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    }
}
