using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome; // Cadiea
            int idade; //Inteiro
            
            Console.WriteLine("Digite seu nome: "); //Escreva
            nome = Console.ReadLine(); //leia
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine()); // converte para número inteiro
            Console.WriteLine("Parabéns " + nome + "! Você acabou de ganhar uma Coca-cola!");
            Console.WriteLine("\n Você possui " + idade + " anos, beba mais água");




        }
    }
}
