using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
 public static class ListaAluno
    {
         public static void Listar()
       {
           using (var ctx = new BancoContext())
           {
               var consultar = from a in ctx.Alunos select a;

               foreach(Aluno a in consultar)
               {
                   Console.WriteLine("Nome: "+a.Nome);
                   Console.WriteLine("Idade: " + a.idade);
                   Console.WriteLine("Logradouro: " + a.Endereco.Lougradouro);
                   Console.WriteLine("Numero: " + a.Endereco.Numero);
                   Console.WriteLine("CEP: " + a.Endereco.CEP);
                   Console.WriteLine("-------------------------");
               }

               
               
           }
       }
    }
}
