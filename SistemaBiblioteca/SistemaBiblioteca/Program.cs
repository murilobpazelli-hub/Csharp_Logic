using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 6;
            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
====================================

SISTEMA DE GESTÃO DE BIBLIOTECA

====================================");
                Console.ResetColor();
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Cadastrar Jogo");
                Console.WriteLine("3 - Cadastrar Cliente");
                Console.WriteLine("4 - Cadastrar Fornecedor");
                Console.WriteLine("5 - Registrar Empréstimo");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("==================================================");
                Console.WriteLine("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            ClasseLivro();

                            break;

                        }
                    case 2:
                        {
                            Console.Clear();
                            ClasseJogo();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            ClasseCliente();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            ClasseFornecedor();
                            break;
                        }
                }
            }
        }
        static void ClasseLivro()
        {
            int id, AnoPublica, qtdExemplares;
            string titulo, autor, ISBN, genero, resposta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"================================================== 

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░         

================================================== ");
            Console.ResetColor();
            Console.WriteLine("Gostaria de cadastrar seu livro? \n(Digite S para continuar)\n (Digite N para voltar ao menu)");
            resposta = Console.ReadLine();
            if (resposta == "S")

                Console.WriteLine("Digite o ID do livro: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o título da obra: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Digite o nome do autor: ");
            autor = Console.ReadLine();
            Console.WriteLine("Digite o Código de identificação internacional: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Digite o ano de lançamento do livro: ");
            AnoPublica = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Categoria do livro: ");
            genero = Console.ReadLine();
            Console.WriteLine("Quantas cópias gostaria de enviar para a biblioteca?: ");
            qtdExemplares = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Cadastro realizado com Sucesso!");
            Console.WriteLine("\nID: " + id);
            Console.WriteLine("\nTítulo: " + titulo);
            Console.WriteLine("\nAutor: " + autor);
            Console.WriteLine("\nISBN: " + ISBN);
            Console.WriteLine("\nAno de publicação: " + AnoPublica);
            Console.WriteLine("\nCategoria: " + genero);
            Console.WriteLine("\n Quantidades Exemplares: " + qtdExemplares);
            Thread.Sleep(3000);


            if (resposta == "N")
            {

                Console.WriteLine("Certo, voltando para o menu...");

                Thread.Sleep(1000);
                Console.Clear();

            }

        }
        static void ClasseJogo()
        {
            int id, FaixaEtaria, NumMinJogadores, NumMaxJogadores, qtdExemplares, qtdJogos;
            string nome, categoria, resposta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"================================================== 

           
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░         

==================================================  ");
            Console.WriteLine("Olá, gostaria de cadastrar quantos jogos?: ");
            qtdJogos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdJogos; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite o ID do jogo: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do jogo: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a categoria do jogo: ");
                categoria = Console.ReadLine();
                Console.WriteLine("Digite a idade mínima recomendada para jogar: ");
                FaixaEtaria = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade mínima de participantes para jogar: ");
                NumMinJogadores = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade máxima de participantes para jogar: ");
                NumMaxJogadores = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantas cópias gostaria de enviar para a biblioteca?: ");
                qtdExemplares = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Cadastro realizado com Sucesso!");
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("\nNome: " + nome);
                Console.WriteLine("\nCategoria: " + categoria);
                Console.WriteLine("\nFaixa Etária: " + FaixaEtaria);
                Console.WriteLine("\nNúmero Mínimo de Jogadores: " + NumMinJogadores);
                Console.WriteLine("\nNúmero Máximo de Jogadores: " + NumMaxJogadores);
                Console.WriteLine("\n Quantidades Exemplares: " + qtdExemplares);
                Console.WriteLine("\n Quantidade de jogos cadastrados: " + i);
                Thread.Sleep(3000);
                if (qtdJogos > 1)
                {

                    Console.WriteLine("\nGostaria de voltar para o menu? \n (Digite S para sair) \n (Digite qualquer outra tecla para continuar) ");
                    resposta = Console.ReadLine();
                    if (resposta == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("Certo, voltando para o menu...");

                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }

                }
            }
        }
        static void ClasseCliente()
        {


            DateTime DataNascimento = new DateTime();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();


        }

        static void ClasseFornecedor()
        {
            int id, qtdFornecedores;
            string RazaoSocial, CNPJ, telefone, Email, Endereco, resposta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.WriteLine("Quantos fornecedores gostaria de colocar?");
            qtdFornecedores = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdFornecedores; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite o ID do Fornecedor");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome jurídico da empresa/editora: ");
                RazaoSocial = Console.ReadLine();
                Console.WriteLine("Digite o Registro nacional (CNPJ) do fornecedor: ");
                CNPJ = Console.ReadLine();
                Console.WriteLine("Digite o Telefone corporativo: ");
                telefone = Console.ReadLine();
                Console.WriteLine("Digite o E-mail de contato comercial: ");
                Email = Console.ReadLine();
                Console.WriteLine("Digite o Logradouro e cidade: ");
                Endereco = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Cadastro realizado com Sucesso!");
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("\nRazão Social: " + RazaoSocial);
                Console.WriteLine("\nRegistro Nacional (CNPJ): " + CNPJ);
                Console.WriteLine("\nTelefone Corporativo: " + telefone);
                Console.WriteLine("\nE-mail: " + Email);
                Console.WriteLine("\nLogradouro e cidade: " + Endereco);
                Thread.Sleep(3000);
                if (qtdFornecedores > 1)
                {

                    Console.WriteLine("\nGostaria de voltar para o menu? \n (Digite S para sair) \n (Digite qualquer outra tecla para continuar) ");
                    resposta = Console.ReadLine();
                    if (resposta == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("Certo, voltando para o menu...");

                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                }


            }
        }
    }
}



