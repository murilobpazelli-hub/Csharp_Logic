using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    internal class Program
    {
        /* Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10;
         * o jogador 2 insere números na tentativa de acertar o número escolhido pelo jogador 1.
         * Quando ele acertar, o algorítmo deve informar que ele acertou o número x (escolhido pelo jogador 1)
         * em x tentativas (quantidade de tentativas do jogador 2).
         */
        static void Main(string[] args)
        {
            int numero1, numero2, tentativas = 1;
            // Boolean == Lógico

            Console.WriteLine("Olá! Jogador 1, por favor digite um número entre 1 e 10 para iniciar o jogo: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Certo. Jogador 2, por favor digite um número entre 1 e 10 para advinhar o número do Jogador 1: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Clear();
            while (numero2 != numero1) {
                Console.WriteLine("Número errado, por favor advinhe outro número: ");
                numero2 = int.Parse(Console.ReadLine()) ;
                tentativas++;
                Console.Clear();
                if (numero2 == numero1)
                {
                    Console.WriteLine("Você advinhou o número do Jogador 1, que é " + numero1 + "!\nNúmero de tentativas do Jogador 2: " + tentativas);
                }
                
            }
            
        }
        }
    }

