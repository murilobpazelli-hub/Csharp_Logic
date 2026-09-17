using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities_2
{
    internal class Program
    {
        /*
         2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
         usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).
        */
        static void Main(string[] args)
        {
            double salary_user, minimum_salary = 1518, result;

            Console.WriteLine("Por favor digite seu salário: ");
            salary_user = double.Parse(Console.ReadLine());
            result = salary_user / minimum_salary;
            Console.WriteLine("Você possui " + result + " salários mínimos");
        }
    }
}
