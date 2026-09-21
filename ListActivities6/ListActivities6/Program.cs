using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities6
{
    /*
     6- Faça um algoritmo que leia o valor de um produto e determine o valor que deve 
        ser pago, conforme a escolha da forma de pagamento
        pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os 
        códigos da tabela de condições de pagamento para efetuar o cálculo adequado.
       Tabela de Código de Condições de Pagamento:
        1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
        2 - À Vista no cartão de crédito, recebe 10% de desconto
        3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
        4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros 
        de 10%
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int parcelado;
            double preco, total;
            string forma_pagamento, forma_cartao;
            Console.WriteLine("Olá, por favor digite o preço de seu produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Certo, por favor escolha sua forma de pagamento: \n(Dinheiro, Pix ou cartão de crédito)\n ");
            forma_pagamento = Console.ReadLine();
            if (forma_pagamento == "Dinheiro" || forma_pagamento == "Pix")
            {
                total = preco - (preco * 0.15);
                Console.WriteLine("Você recebeu um desconto de 15%! Seu valor final será de " + total);
            }
            if (forma_pagamento == "Cartão de crédito")
            {
                Console.WriteLine("Gostaria de fazer à Vista ou Parcelado?");
                forma_cartao = Console.ReadLine();
                if (forma_cartao == "À Vista")
                {
                    total = preco - (preco * 0.1);
                        Console.WriteLine("Você recebeu um desconto de 10%! Seu valor final será de " + total);
                }
                if (forma_cartao == "Parcelado")
                {
                    Console.WriteLine("Quantas vezes gostaria de parcelar?");
                    parcelado = int.Parse(Console.ReadLine());
                    if (parcelado == 2)
                    {
                        Console.WriteLine("Seu valor final será de " + preco + ". Sem juros.");
                    }
                    if (parcelado >= 3)
                    {
                        total = preco + (preco * 0.1);
                        Console.WriteLine("Seu valor final será de " + total + ". Com juros de 10%.");
                    }
                }
            }



        }
    }
}
