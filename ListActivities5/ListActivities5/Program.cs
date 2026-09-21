using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities5
{
    internal class Program
    {
        /*
         5- Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma 
         pessoa, leia o seu peso e sua altura e imprima na tela sua condição
         de acordo com a tabela abaixo:
         Fórmula do IMC = peso / (altura) ²
         Tabela Condições IMC:
         Abaixo de 18,5 | Abaixo do peso 
         Entre 18,6 e 24,9 | Peso ideal (parabéns) 
         Entre 25,0 e 29,9 | Levemente acima do peso
         Entre 30,0 e 34,9 | Obesidade grau I
         Entre 35,0 e 39,9 | Obesidade grau II (severa)
         Maior ou igual a 40 | Obesidade grau III (mórbida)

         BMI = Body Mass Index
         */
        static void Main(string[] args)
        {
            double weight, height, BMI;
            Console.WriteLine("Olá, iremos calcular seu IMC (Índice de Massa Corporal) e verificar se está no peso ideal. \nPor favor digite seu peso abaixo:\n");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Certo, agora digite sua altura:\n");
            height = double.Parse(Console.ReadLine());
            BMI = weight / (height * height);
            if (BMI <= 18.5)
            {
                Console.WriteLine("\nVocê está abaixo do peso. IMC = " + BMI);

            }
            else if (BMI >= 18.6 && BMI <= 24.9)
            {
                Console.WriteLine("\nVocê tem o peso ideal, parabéns! IMC = " + BMI);
            }
            else if (BMI >= 25.0 && BMI <= 29.9)
            {
                Console.WriteLine("\nVocê está levemente acima do peso. IMC = " + BMI);
            }
            else if (BMI >= 30.0 && BMI <= 34.9)
            {
                Console.WriteLine("\nVocê está com obesidade grau I. IMC = " + BMI);
            }
            else if (BMI >= 35.0 && BMI <= 39.9)
            {
                Console.WriteLine("\nVocê está com obesidade grau II (severa). IMC = " + BMI);
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("\nVocê está com obesidade grau III (mórbida). IMC = " + BMI);
            }
        }
    }
}
