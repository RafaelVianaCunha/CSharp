using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {

            insereAluno.insere();
            //using (var ctx = new BancoContext())
            //{
            //    Aluno a1 = new Aluno
            //    {
            //        Nome = "Fernanda Moura",
            //        Endereco = new Endereco
            //        {
            //            Lougradouro = "Rua Amalera",
            //            Numero = 2907,
            //            CEP = "09147-001"
            //        }
            //    };

            //    Aluno a2 = new Aluno
            //    {
            //        Nome = "Luiz Paulo",
            //        Endereco = new Endereco
            //        {
            //            Lougradouro = "Rua Alto Do Ouro",
            //            Numero = 01,
            //            CEP = "21775-230"
            //        }
            //    };

            //    Professor p = new Professor
            //    {
            //        Nome = "Rafael Pinho",
            //        Endereco = new Endereco
            //        {
            //            Lougradouro = "Rua Meravelha",
            //            Numero = 8367,
            //            CEP = "00876-100"
            //        }
            //    };

            //    Turma t = new Turma
            //    {
            //        Vagas = 10,
            //        Alunos = new List<Aluno>()
            //    };

            //    t.Professor = p;
            //    t.Alunos.Add(a1);
            //    t.Alunos.Add(a2);

            //    ctx.Alunos.Add(a1);
            //    ctx.Alunos.Add(a2);
            //    ctx.Professores.Add(p);
            //    ctx.Turmas.Add(t);
            //    ctx.SaveChanges();
            //}          
        }
    }
}
