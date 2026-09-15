using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_stock2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, quantidadeBranco = 0, quantidadeTinto = 0;
            string vinhos;
            for (contador = 1; contador > 0; contador++)
            {
                Console.WriteLine("Digite qual o tipo de vinho ou digite 'f' para finalizar o programa \n Digite ('t' para vinho tinto e 'b' para vinho branco): ");
                vinhos = Console.ReadLine();
                if (vinhos == "t")
                {
                    quantidadeTinto++;
                }
                if (vinhos == "b")
                {
                    quantidadeBranco++;
                }
                Console.Clear();
                if (vinhos == "f")
                {
                    Console.WriteLine("O total de vinhos brancos em estoque são: " + quantidadeBranco + "\ne o de vinhos tintos são: " + quantidadeTinto);
                    break;
                }
            }
        }
    }
}
