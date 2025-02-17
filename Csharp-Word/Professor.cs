using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Word
{
    public class Professor
    {
        //Atributos(Attribute)
        public string Nome;
        public string Disciplina;

        //construtor
        public Professor(string nome, string disciplina)
        {
            Nome = nome;
            Disciplina = disciplina;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Professor: {Nome}, Disciplina: {Disciplina}");
        }
       
    }
}
