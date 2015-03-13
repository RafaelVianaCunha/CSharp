using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityTest

{   
    public class Aluno
    {        
        public int AlunoID { get; set; }          
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int idade { get; set; }       
    }
}
