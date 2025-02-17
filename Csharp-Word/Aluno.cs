using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Word
{
    public class Aluno
    {
        //Atributos(Attribute)
        public string nome;
        public double nota1, nota2;

        //Média(Average)
        public double media()
        {
            return (nota1 + nota2) / 2;
        }

        //Situação(Situation)

        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }
        //Mensagem(Message)

        public void mensagem()
        {
            //obter a média
            double obterMedia = media();

            //obter a situação
            string obterSituacao = situacao(obterMedia);

            //mensagem
            Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}");
        }
    }
}
