using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[5];

            int contadorInserirNomes = 0;
            while (contadorInserirNomes < nomes.Length)
            {
                Console.WriteLine("Digite o nome do Funcionario: " + (contadorInserirNomes + 1));
                nomes[contadorInserirNomes] = Console.ReadLine();

                contadorInserirNomes++;
                Console.Clear();
            }

            int contadorMostrarNomes = 0;
            while (contadorMostrarNomes < nomes.Length)
            {
                
                
                
                    Console.WriteLine(nomes[contadorMostrarNomes]);                
             
                
                contadorMostrarNomes++;
            }

            Console.ReadKey();









        }
    }
}
