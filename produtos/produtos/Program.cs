using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um algorítimo para cadastro de produto: Código, Fabricante, categoria, preço, estoque e valor total em estoque.*/
            int code, storage;
            string manufacturer, category;
            double price, total;
            Console.WriteLine("Digite o código: ");
            code = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o fabricante: ");
            manufacturer = Console.ReadLine();
            Console.WriteLine("Digite a categoria: ");
            category = Console.ReadLine();
            Console.WriteLine("Digite o preço: ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estoque: ");
            storage = int.Parse(Console.ReadLine());
            total = price * storage;
            Console.WriteLine("O valor total em estoque é " + total);
            
        }
    }
}
