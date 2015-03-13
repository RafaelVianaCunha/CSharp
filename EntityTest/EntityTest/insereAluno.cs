using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public static class insereAluno
    {
       public static void insere()
       {
           using (var ctx = new BancoContext())
           {
               Endereco e = new Endereco();
               Aluno a = new Aluno();

               Console.WriteLine("Digite o nome do aluno");
               a.Nome = Console.ReadLine();

               Console.WriteLine("Digite o logradoura do aluno");
               e.Lougradouro = Console.ReadLine();

               Console.WriteLine("Digite o numero do aluno");
               e.Numero = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Digite o Cep do aluno");
               e.CEP = Console.ReadLine();               
               a.Endereco = e;
               ctx.Alunos.Add(a);
               ctx.SaveChanges();



           }
       }
    }
}
