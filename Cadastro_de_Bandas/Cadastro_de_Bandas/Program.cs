using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; /* Biblioteca Thread */
namespace Cadastro_de_Bandas
{
    internal class Program
    {
        /*
         Caso = switch
         Usado em opções de escolha
         Função = bloco de comandos
         Crie um sistema de cadastro de Álbuns de um artista/ banda em que será possível cadastrar um número X de músicas informadas pelo usuário. Crie um menu de opções para isso.

         */
        static void Main(string[] args) /* <--- Isso é um bloco de comando! */
        {
            int opcao = 0;
            while (opcao != 4)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" 1 - Cadastrar Album da Banda");
                Console.WriteLine(" 2 - Cadastrar Album do Artista"); // Ano, Nome artista, qtd album, qtd vendas
                Console.WriteLine(" 3 - Cadastrar Músicas"); // digitar qtd musicas (nome musica, duração, premiação) 
                Console.WriteLine(" 4 - Sair do Programa");
                Console.WriteLine(" -----> ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        BandasAlbum();

                        break;
                    case 2:
                        ArtistaAlbum();
                        break;
                    case 3:
                        CadastroMusicas();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa!! Tchau tchau :)");
                        break;




                }
            }
        }
        static void BandasAlbum() /* <--- Isso também é um bloco de comando! Você consegue criar varios blocos de comando para organizar seu algorítmo */
        {
            string nomeBanda, nomeAlbum;
            int qtdMusicas;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗  ██████╗░░█████╗░  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║  ██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║  ██║░░██║███████║  ██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║  ██║░░██║██╔══██║  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║  ██████╔╝██║░░██║  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝  ╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.WriteLine("Digite o nome da Banda: ");
            nomeBanda = Console.ReadLine();
            Console.WriteLine("Digite o nome do Album: ");
            nomeAlbum = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de Músicas: ");
            qtdMusicas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cadastro realizado com Sucesso !!! ");
            Console.WriteLine("\n" + nomeBanda);
            Console.WriteLine("\n" + nomeAlbum);
            Console.WriteLine("\n" + qtdMusicas);
            Thread.Sleep(3000);
        }
        static void ArtistaAlbum()
        {
            string nomeArtista;
            int AnoArtista, qtdAlbum, qtdVendas;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗  ██████╗░░█████╗░
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║  ██╔══██╗██╔══██╗
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║  ██║░░██║██║░░██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║  ██║░░██║██║░░██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║  ██████╔╝╚█████╔╝
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░

░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.WriteLine("Digite o Ano em que o Álbum lançou: ");
            AnoArtista = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do artista desse Álbum: ");
            nomeArtista = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de Álbums que esse artista fez: ");
            qtdAlbum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de vendas desse Álbum");
            qtdVendas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cadastro realizado com Sucesso !!! ");
            Console.WriteLine("\n" + AnoArtista);
            Console.WriteLine("\n" + nomeArtista);
            Console.WriteLine("\n" + qtdAlbum);
            Console.WriteLine("\n" + qtdVendas);
            Thread.Sleep(3000);

        }
        static void CadastroMusicas()
        {
            int qtdMusicas, contador;
            double duracao;
            string nomeMusica, premiacoes;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░░██████╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗██╔════╝
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║╚█████╗░
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║░╚═══██╗
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("Digite a quantidade de músicas que gostaria de registrar: ");
            qtdMusicas = int.Parse(Console.ReadLine());
            for (contador = 0; contador <= qtdMusicas; contador++) {
                Console.WriteLine("Qual é o nome da música nº "+ contador + "?");
                nomeMusica = Console.ReadLine();
                Console.WriteLine("Qual é o tempo de duração dessa música?: ");
                duracao = double.Parse(Console.ReadLine());
                Console.WriteLine("Quais premiações essa música já teve?: ");
                premiacoes = Console.ReadLine();
                Console.WriteLine("Cadastro realizado com Sucesso !!! ");
                Console.WriteLine("\n" + nomeMusica);
                Console.WriteLine("\n" + duracao);
                Console.WriteLine("\n" + premiacoes);
                Thread.Sleep(3000);
                Console.Clear();
            }

        }
    } 
}
