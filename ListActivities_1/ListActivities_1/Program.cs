using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities_1
{
    internal class Program
    {/*
      1-	Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
      caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
      imprimir seu valor na tela. 
     */
        static void Main(string[] args)
        {
            int numberA, numberB, resultC;
            Console.WriteLine("Por favor digite o primeiro número: ");
            numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o segundo número: ");
            numberB = int.Parse(Console.ReadLine());
            if (numberA == numberB)
            {
                resultC = numberA + numberB;
                Console.WriteLine("Como seus números são iguais, a soma foi efetuada, resultando em " + resultC);
            }
            else
            {
                resultC = numberA * numberB;
                Console.WriteLine("Como seus números são diferentes, a multiplicação foi efetuada, resultando em " + resultC);
            }
        }
    }
}
