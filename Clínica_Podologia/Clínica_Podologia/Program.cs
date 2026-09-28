using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clínica_Podologia
{ 

   
}
internal class Program
{ /*
       Atividade Prática: Sistema de Agendamento para Clínica de Podologia (C# Console) 

       Objetivo:

       Mapear os requisitos de atendimento da clínica, implementar a estrutura de Funçãos com atributos específicos da podologia e construir uma interface via terminal (switch-case com do-while) para gerenciar clientes, profissionais, serviços e consultas. 

       Requisitos do Projeto: Estrutura de Campos 

       Crie uma Função para cada entidade do sistema com os devidos tipos de dados em C#: 
       
       */

    static void Main(string[] args)
    {
        int opcao = 7;
        string sair;
        while (opcao != 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"================================================== 

           CLÍNICA DE PODOLOGIA - AGENDAMENTOS     

================================================== ");
            Console.ResetColor();
            Console.WriteLine("1 - Cadastrar Cliente (Ficha Rápida) ");
            Console.WriteLine("2 - Cadastrar Podólogo ");
            Console.WriteLine("3 - Cadastrar Procedimento/Serviço ");
            Console.WriteLine("4 - Agendar Consulta ");
            Console.WriteLine("5 - Listar Agendamentos ");
            Console.WriteLine("6 - Exibir Todos os Cadastros \r\n");
            Console.WriteLine("0 - Sair ");
            Console.WriteLine("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 0:

                    Console.Clear();
                    Console.WriteLine("Tem certeza que deseja sair?:");
                    sair = Console.ReadLine();
                    if (sair == "Sim")
                    {
                        Console.WriteLine("Saindo do programa, tchau tchau! ;) ");
                        break;
                    }
                    if (sair == "Não")
                    {
                        opcao = 7;
                    }
                    break;
                case 1:

                    Console.Clear();
                    ClientePodologia();
                    break;

                case 2:
                    Console.Clear();
                    FuncaoPodologo();
                    break;

                case 3:
                    Console.Clear();
                    FuncaoProcedimento();
                    break;
                case 4:
                    Console.Clear();
                    FuncaoAgendamento();
                    break;
                   case 5:
                    Console.Clear();
                    ListarAgendamentos();
                    break;







            }
        }
    }
    static void ClientePodologia()
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▀ █░░ █ █▀▀ █▄░█ ▀█▀ █▀▀ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▄ █▄▄ █ ██▄ █░▀█ ░█░ ██▄ ▄█");


        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkGray;


        bool continuar = true;

        while (continuar)

        {

            Console.WriteLine("Digite o identificador unico do paciente: ");

            int id = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite o nome completo do paciente: ");

            string nome = Console.ReadLine();


            Console.WriteLine("Digite o cpf do cliente: ");

            string cpf = (Console.ReadLine());


            Console.WriteLine("Digite o telefone do paciente: ");

            string telefone = Console.ReadLine();


            Console.WriteLine("Digite a data de nascimento do paciente  : ");

            DateTime dtNasc = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("O paciente possui Diabetes? (true/false): ");

            bool possuiDiabetes = bool.Parse(Console.ReadLine());


            Console.WriteLine("Observaçoes (ex: feridas, alergias ,condiçoes previas): ");

            string obs = Console.ReadLine();


            Console.WriteLine("Cadastro realizado com sucesso!");



            Console.WriteLine("\n" + id);

            Console.WriteLine("\n" + nome);

            Console.WriteLine("\n" + cpf);

            Console.WriteLine("\n" + telefone);

            Console.WriteLine("\n" + dtNasc);

            Console.WriteLine("\n" + possuiDiabetes);

            Console.WriteLine("\n" + obs);


            Console.WriteLine("Deseja cadastrar outro paciente? (s/n): ");

            string resposta = Console.ReadLine();


            if (resposta != "s")

            {

                continuar = false;

            }








        }
    }
    static void FuncaoPodologo()


        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░░█████╗░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██╔══██╗██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║░░██║██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║░░██║██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝╚█████╔╝╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░░╚════╝░");


            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;


            bool continuar = true;

            while(continuar)

            {

              Console.WriteLine("Digite o identificador unico do especialista: ");

              int id = int.Parse(Console.ReadLine());



    Console.WriteLine("Digite o nome completo do especialista: ");

              string nome = Console.ReadLine();


    Console.WriteLine("Digite o numero do conselho/registro tecnico: ");

              string registec = (Console.ReadLine());


    Console.WriteLine("Digite a especialidade do profissional: ");

                string espec = Console.ReadLine();


    Console.WriteLine("Digite o telefone do especialista: ");

              string tel = Console.ReadLine();



    Console.WriteLine("Cadastro realizado com sucesso!");



            Console.WriteLine("\n"+id);

            Console.WriteLine("\n"+nome);

            Console.WriteLine("\n"+registec);

            Console.WriteLine("\n"+espec);

            Console.WriteLine("\n"+tel);


            Console.WriteLine("Deseja cadastrar outro especialista? (s/n): ");

            string resposta = Console.ReadLine();


            if(resposta == "s")

            {

            continuar = false;

            }

          






    }


      }
    public static class Variaveis
    {
        public static string status;
        public static int id, codcl, codesp, codproced;
        public static DateTime data;





    }
    static void FuncaoProcedimento()


    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █▀▀ █▀▀ █▀▄ █ █▀▄▀█ █▀▀ █▄░█ ▀█▀ █▀█ █▀   █▀▀█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀▀ █▀▄ █▄█ █▄▄ ██▄ █▄▀ █ █░▀░█ ██▄ █░▀█ ░█░ █▄█ ▄█   ██▄█▀ █▀▀ █▀█ █░█ █ █▀▀ █▀█ █▀▄█ ██▄ █▀▄ ▀▄▀ █ █▄▄ █▄█ ▄█");


        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkGray;


        bool continuar = true;

        while (continuar)

        {

            Console.WriteLine("Digite o identificador unico do procedimento: ");

            int id = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite o nome do procedimento (ex: podopatia, onicocriptose, laserterapia): ");

            string nome = Console.ReadLine();


            Console.WriteLine("Tempo estimado do procedimento (em minutos): ");

            int temp = int.Parse(Console.ReadLine());


            Console.WriteLine("Valor do procedimento: ");

            decimal valor = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Cadastro realizado com sucesso!");



            Console.WriteLine("\n" + id);

            Console.WriteLine("\n" + nome);

            Console.WriteLine("\n" + temp);

            Console.WriteLine("\n" + valor);


            Console.WriteLine("Deseja cadastrar outro procedimento? (s/n): ");

            string resposta = Console.ReadLine();


            if (resposta == "s")

            {

                continuar = false;

            }








        }


    }
    static void FuncaoAgendamento()


        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █▀▀ █▀▀ █▀▄ █ █▀▄▀█ █▀▀ █▄░█ ▀█▀ █▀█ █▀   █▀▀█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀▀ █▀▄ █▄█ █▄▄ ██▄ █▄▀ █ █░▀░█ ██▄ █░▀█ ░█░ █▄█ ▄█   ██▄█▀ █▀▀ █▀█ █░█ █ █▀▀ █▀█ █▀▄█ ██▄ █▀▄ ▀▄▀ █ █▄▄ █▄█ ▄█");


            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;


            bool continuar = true;

            while(continuar)

            {

              Console.WriteLine("Digite o identificador unico do agendamento: ");

              Variaveis.id = int.Parse(Console.ReadLine());



    Console.WriteLine("Digite o codigo do cliente cadastrado  : ");

            Variaveis.codcl = int.Parse(Console.ReadLine());



    Console.WriteLine("Digite o codigo do especialista resposavel pelo procedimento: ");

            Variaveis.codesp = int.Parse(Console.ReadLine());


    Console.WriteLine("Digite o codigo do procedimento: ");

            Variaveis.codproced = int.Parse(Console.ReadLine());


    Console.WriteLine("Digite a data e hora do agendamento (formato: dd/mm/yyyy hh:mm): ");

            Variaveis.data = DateTime.Parse(Console.ReadLine());


    Console.WriteLine("Digite o status do agendamento(agendado, concluido ou cancelado): ");

            Variaveis.status = Console.ReadLine();


    Console.WriteLine("Cadastro realizado com sucesso!");



            Console.WriteLine("\n"+ Variaveis.id);

            Console.WriteLine("\n"+ Variaveis.codcl);

            Console.WriteLine("\n"+ Variaveis.codesp);

            Console.WriteLine("\n"+ Variaveis.codproced);

            Console.WriteLine("\n"+ Variaveis.data);

            Console.WriteLine("\n"+ Variaveis.status);


            Console.WriteLine("Deseja fazer outro agendamento? (s/n): ");

            string resposta = Console.ReadLine();


            if(resposta == "s")

            {

            continuar = false;

            }

          






    }


      }
   

      
    // --- FUNÇÃO 5: Puxar e Listar Todos os Agendamentos ---
    static void ListarAgendamentos()
    {
        Console.Clear();
        Console.WriteLine("=== 5. LISTA DE TODOS OS AGENDAMENTOS ===");


        Console.WriteLine("\n" + Variaveis.id);

        Console.WriteLine("\n" + Variaveis.codcl);

        Console.WriteLine("\n" + Variaveis.codesp);

        Console.WriteLine("\n" + Variaveis.codproced);

        Console.WriteLine("\n" + Variaveis.data);

        Console.WriteLine("\n" + Variaveis.status);
        Thread.Sleep(3000);
    }
}

