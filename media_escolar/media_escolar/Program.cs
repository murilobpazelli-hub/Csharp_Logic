using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, media;
            string nome;
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            num4 = double.Parse(Console.ReadLine());
            media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("O nome do aluno é " + nome + " e a média dele é " + media);
        }
    }
}
