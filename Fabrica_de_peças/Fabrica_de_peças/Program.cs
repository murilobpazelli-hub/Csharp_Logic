using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_peças
{
    internal class Program
    {
        /* Uma fábrica  tem uma linha de produção capaz de produzir 400 peças por dia.
         * Um funcionário controla a qualidade, cadastrando o número da peça e o seu estado (aprovado ou reprovado). 
         * Crie um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.
         */
        static void Main(string[] args)
        {
            int dado, contador = 0, aprovado_total = 0, reprovado_total = 0;
            string estado;
            
         while (contador != 40)
            {
                Console.WriteLine("Olá! Por favor digite o número de sua peça abaixo: \n (Caso queira finalizar o programa, aperte 0)");
                dado = int.Parse(Console.ReadLine());
                if (dado == 0)
                {
                    Console.WriteLine("Programa finalizado!\n Peças aprovadas: " + aprovado_total + "\n Peças reprovadas: " + reprovado_total);
                    break;
                }
                Console.WriteLine("Certo, por favor declare o estado da peça:\n(a = aprovado/)\n(r = reprovado) ");
                estado = Console.ReadLine();
                if (estado == "a")
                {
                    aprovado_total++;
                    contador++;
                    Console.Clear();
                }
                if (estado == "r")
                {
                    reprovado_total++;
                    contador++;
                    Console.Clear();
                }

                
                if (contador == 40)
                {
                    Console.WriteLine("Programa finalizado!\n Peças aprovadas: " + aprovado_total + "\n Peças reprovadas: " + reprovado_total);
                    break;
                }
            }
            
        }
    }
}