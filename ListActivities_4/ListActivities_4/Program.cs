using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities_4
{
    internal class Program
    {
        /*
         4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.
         */
        static void Main(string[] args)
        {
            Boolean resposta1, resposta2;
            Console.WriteLine("Bem vindo a Show do bilhão! Responda essas duas perguntas e ganhe absolutamente nada! \nPrimeira pergunta:  O Brasil teve independência em 1500, verdadeiro ou falso?\n");
            resposta1 = Boolean.Parse(Console.ReadLine());
            if (resposta1 == false)
            {
                Console.WriteLine("Maoe! Certa a resposta! Agora vamos para a segunda pergunta: A capital do Brasil é Brasília, verdadeiro ou falso? ");
                resposta2 = Boolean.Parse(Console.ReadLine());
                if (resposta2 == true)
                {
                    Console.WriteLine("Maoe! Parabéns! Você ganhou absolutamente nada!");
                }
                if (resposta2 == false)
                {
                    {
                        Console.WriteLine("Resposta errada!");
                    }
                }
            }
            if (resposta1 == true) {
                
                Console.WriteLine("Resposta errada!");
            }
        }
    }
}
