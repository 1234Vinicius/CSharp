using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios2
{
    class Program
    {
        static void Main(string[] args)
        {

            string frasePrincipal = "Olá, bom dia. Sou aluno do Senac Vila Prudente.";

            string frase = frasePrincipal.Substring(14);
            string fraseDois = frasePrincipal.Substring(27, 19);

            Console.WriteLine("2ª frase - " + frase);
            Console.WriteLine("Unidade - " + fraseDois);


            Console.ReadKey();

        }
    }
}
