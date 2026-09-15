using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_stock
{
    internal class Program
    {
        /* Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada  tipos de vinho, sendo: "t"
         * para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida, utilize a letra "f" para finalizar. Após finalizar o programa deve mostrar a 
         quantidade de cada vinho na adega.
        */
        static void Main(string[] args)
        {
            string wine;
            int countertinto = 0, counterbranco = 0;
            Console.WriteLine("Olá, bem vindo a Adega. Por favor escolha um dos vinhos abaixo: \n");
            Console.WriteLine("Tinto (digite 't'): \n");
            Console.WriteLine("Branco (digite 'b'): \n");
            Console.WriteLine("(digite 'f' para finalizar) ");
            wine = Console.ReadLine();
            while (wine != "f")
            {
                if (wine == "t")
                {
                    countertinto++;
                    Console.WriteLine("\n Você escolheu um vinho tinto,\n");
                    Console.WriteLine("Tinto (Aperte 't'): \n");
                    Console.WriteLine("Branco (Aperte 'b'): \n");
                    Console.WriteLine("(digite 'f' para finalizar) \n ");
                    wine = Console.ReadLine();
                }
                if (wine == "b")
                {
                    counterbranco++;
                    Console.WriteLine("\n Você escolheu um vinho branco, gostaria de escolher outro?\n");
                    Console.WriteLine("Tinto (Aperte 't'): \n");
                    Console.WriteLine("Branco (Aperte 'b'): \n");
                    Console.WriteLine("(digite 'f' para finalizar) \n ");
                    wine = Console.ReadLine();

                }
            }
            Console.WriteLine("Finalizado! Foram escolhidas " + countertinto + " garrafas de vinho tinto e " + counterbranco+ " de vinho branco.");
        }
    }
}