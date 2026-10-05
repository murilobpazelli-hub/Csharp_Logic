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
                case 6:
                    Console.Clear();
                    TodosCadastros();
                    break;




            }
        }
    }
    public static class VariaveisCliente
    {
        public static int IdCliente;
        public static string nomeCliente, CPFcliente, TelefoneCliente, Obs;
        public static DateTime dataNasc;
        public static bool Diabetes;

    }
    static void ClientePodologia()
    {
        bool continuar = true;
        while (continuar)

        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▀ █░░ █ █▀▀ █▄░█ ▀█▀ █▀▀ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▄ █▄▄ █ ██▄ █░▀█ ░█░ ██▄ ▄█");


            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;


            Console.WriteLine("Digite o identificador unico do paciente: ");

            VariaveisCliente.IdCliente = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome completo do paciente: ");

            VariaveisCliente.nomeCliente = Console.ReadLine();


            Console.WriteLine("Digite o cpf do cliente: ");

            VariaveisCliente.CPFcliente = (Console.ReadLine());


            Console.WriteLine("Digite o telefone do paciente: ");

            VariaveisCliente.TelefoneCliente = Console.ReadLine();


            Console.WriteLine("Digite a data de nascimento do paciente  : ");

            VariaveisCliente.dataNasc = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("O paciente possui Diabetes? (true/false): ");

            VariaveisCliente.Diabetes = bool.Parse(Console.ReadLine());


            Console.WriteLine("Observaçoes (ex: feridas, alergias ,condiçoes previas): ");

            VariaveisCliente.Obs = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Cadastro realizado com sucesso!");



            Console.WriteLine("\nID do paciente: " + VariaveisCliente.IdCliente);

            Console.WriteLine("\nNome do paciente: " + VariaveisCliente.nomeCliente);

            Console.WriteLine("\nCPF do paciente: " + VariaveisCliente.CPFcliente);

            Console.WriteLine("\nTelefone do paciente: " + VariaveisCliente.TelefoneCliente);

            Console.WriteLine("\nData de nascimento do paciente: " + VariaveisCliente.dataNasc);

            Console.WriteLine("\nPossui diabetes?: " + VariaveisCliente.Diabetes);

            Console.WriteLine("\nObservações: " + VariaveisCliente.Obs);


            Thread.Sleep(3000);

            Console.WriteLine("\nDeseja cadastrar outro paciente? (s/n): ");

            string resposta = Console.ReadLine();


            if (resposta != "s")

            {

                continuar = false;

            }





        }
    }
    public static class VariaveisPodologo
    {
        public static int IdPodologo;
        public static string nomePodologo, RegisTecPodologo, EspecPodologo, TelefonePodologo;
    }
    static void FuncaoPodologo()


    {
        bool continuar = true;
        while (continuar)

        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░
 
██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░██║░░██║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██║░░██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝╚█████╔╝
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░░╚════╝░");


            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;




            Console.WriteLine("Digite o identificador unico do especialista: ");

            VariaveisPodologo.IdPodologo = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome completo do especialista: ");

            VariaveisPodologo.nomePodologo = Console.ReadLine();


            Console.WriteLine("Digite o numero do conselho/registro tecnico: ");

            VariaveisPodologo.RegisTecPodologo = (Console.ReadLine());


            Console.WriteLine("Digite a especialidade do profissional: ");

            VariaveisPodologo.EspecPodologo = Console.ReadLine();


            Console.WriteLine("Digite o telefone do especialista: ");

            VariaveisPodologo.TelefonePodologo = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Cadastro realizado com sucesso!");



            Console.WriteLine("\nID do especialista: " + VariaveisPodologo.IdPodologo);

            Console.WriteLine("\nNome Completo do especialista: " + VariaveisPodologo.nomePodologo);

            Console.WriteLine("\nNúmero do conselho/Registro Técnico do especialista: " + VariaveisPodologo.RegisTecPodologo);

            Console.WriteLine("\nEspecialidade profissional: " + VariaveisPodologo.EspecPodologo);

            Console.WriteLine("\nTelefone do especialista: " + VariaveisPodologo.TelefonePodologo);


            Thread.Sleep(3000);


            Console.WriteLine("\nDeseja cadastrar outro especialista? (s/n): ");

            string resposta = Console.ReadLine();


            if (resposta != "s")

            {

                continuar = false;

            }





        }





    }
    public static class VariaveisProcedimento
    {
        public static int IdProcedimento, tempoProcedimento;
        public static string nomeProcedimento;
        public static decimal valorProcedimento;
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

            VariaveisProcedimento.IdProcedimento = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome do procedimento (ex: podopatia, onicocriptose, laserterapia): ");

            VariaveisProcedimento.nomeProcedimento = Console.ReadLine();


            Console.WriteLine("Digite o tempo estimado do procedimento (em minutos): ");

            VariaveisProcedimento.tempoProcedimento = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor do procedimento: ");

            VariaveisProcedimento.valorProcedimento = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Cadastro realizado com sucesso!");


            Console.WriteLine("\nID do procedimento/serviço: " + VariaveisProcedimento.IdProcedimento);

            Console.WriteLine("\nNome do procedimento/serviço: " + VariaveisProcedimento.nomeProcedimento);

            Console.WriteLine("\nTempo estimado do procedimento: " + VariaveisProcedimento.tempoProcedimento);

            Console.WriteLine("\nValor do procedimento: " + VariaveisProcedimento.valorProcedimento);


            Console.WriteLine("\nDeseja cadastrar outro procedimento? (s/n): ");

            string resposta = Console.ReadLine();


            if (resposta != "s")

            {

                continuar = false;

            }





        }


    }
    public static class VariaveisAgendamento
    {
        public static string status;
        public static int id, codcl, codesp, codproced;
        public static DateTime data;


    }
    static void FuncaoAgendamento()


    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █▀▀ █▀▀ █▀▄ █ █▀▄▀█ █▀▀ █▄░█ ▀█▀ █▀█ █▀   █▀▀█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀▀ █▀▄ █▄█ █▄▄ ██▄ █▄▀ █ █░▀░█ ██▄ █░▀█ ░█░ █▄█ ▄█   ██▄█▀ █▀▀ █▀█ █░█ █ █▀▀ █▀█ █▀▄█ ██▄ █▀▄ ▀▄▀ █ █▄▄ █▄█ ▄█");


        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkGray;


        bool continuar = true;

        while (continuar)

        {

            Console.WriteLine("Digite o identificador unico do agendamento: ");

            VariaveisAgendamento.id = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o codigo do cliente cadastrado  : ");

            VariaveisAgendamento.codcl = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o codigo do especialista resposavel pelo procedimento: ");

            VariaveisAgendamento.codesp = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o codigo do procedimento: ");

            VariaveisAgendamento.codproced = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite a data e hora do agendamento (formato: dd/mm/yyyy hh:mm): ");

            VariaveisAgendamento.data = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Digite o status do agendamento(agendado, concluido ou cancelado): ");

            VariaveisAgendamento.status = Console.ReadLine();


            Console.WriteLine("Cadastro realizado com sucesso!");


            Console.WriteLine("\nID do Agendamento: " + VariaveisAgendamento.id);

            Console.WriteLine("\nCódigo do cliente cadastrado: " + VariaveisAgendamento.codcl);

            Console.WriteLine("\nCódigo do responsável pelo procedimento: " + VariaveisAgendamento.codesp);

            Console.WriteLine("\n Código do procedimento: " + VariaveisAgendamento.codproced);

            Console.WriteLine("\nData e hora do agendamento: " + VariaveisAgendamento.data);

            Console.WriteLine("\nStatus do agendamento: " + VariaveisAgendamento.status);


            Console.WriteLine("Deseja fazer outro agendamento? (OBS: Ele substituirá os dados do agendamento anterior) (s/n): ");

            string resposta = Console.ReadLine();


            if (resposta != "s")

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

        Console.WriteLine("Aqui estão todos seus agendamentos: ");

        Console.WriteLine("\nID do Agendamento: " + VariaveisAgendamento.id);

        Console.WriteLine("\nCódigo do cliente cadastrado: " + VariaveisAgendamento.codcl);

        Console.WriteLine("\nCódigo do responsável pelo procedimento: " + VariaveisAgendamento.codesp);

        Console.WriteLine("\n Código do procedimento: " + VariaveisAgendamento.codproced);

        Console.WriteLine("\nData e hora do agendamento: " + VariaveisAgendamento.data);

        Console.WriteLine("\nStatus do agendamento: " + VariaveisAgendamento.status);
        Thread.Sleep(3000);
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadLine();
    }
    static void TodosCadastros()
    {
        bool saida = false;
        string cadastro, resposta;
        while (saida != true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║╚█████╗░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║░╚═══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝██████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░
 
███████╗███████╗██╗████████╗░█████╗░░██████╗██╗
██╔════╝██╔════╝██║╚══██╔══╝██╔══██╗██╔════╝╚═╝
█████╗░░█████╗░░██║░░░██║░░░██║░░██║╚█████╗░░░░
██╔══╝░░██╔══╝░░██║░░░██║░░░██║░░██║░╚═══██╗░░░
██║░░░░░███████╗██║░░░██║░░░╚█████╔╝██████╔╝██╗
╚═╝░░░░░╚══════╝╚═╝░░░╚═╝░░░░╚════╝░╚═════╝░╚═╝");
            Console.ResetColor();
            Console.WriteLine("Qual cadastro gostaria de acessar?");
            Console.WriteLine("(Cliente)");
            Console.WriteLine("(Podólogo)");
            Console.WriteLine("(Procedimento/Serviço)\n");
            cadastro = Console.ReadLine();
            if (cadastro == "Cliente")
            {
                Console.Clear();

                Console.WriteLine("Aqui estão os dados de cadastro do paciente: ");

                Console.WriteLine("\nID do paciente: " + VariaveisCliente.IdCliente);

                Console.WriteLine("\nNome do paciente: " + VariaveisCliente.nomeCliente);

                Console.WriteLine("\nCPF do paciente: " + VariaveisCliente.CPFcliente);

                Console.WriteLine("\nTelefone do paciente: " + VariaveisCliente.TelefoneCliente);

                Console.WriteLine("\nData de nascimento do paciente: " + VariaveisCliente.dataNasc);

                Console.WriteLine("\nPossui diabetes?: " + VariaveisCliente.Diabetes);

                Console.WriteLine("\nObservações: " + VariaveisCliente.Obs);

                Thread.Sleep(5000);


            }
            if (cadastro == "Podólogo")
            {
                Console.Clear();
                Console.WriteLine("Aqui estão os dados de cadastro do podólogo: ");

                Console.WriteLine("\nID do especialista: " + VariaveisPodologo.IdPodologo);

                Console.WriteLine("\nNome Completo do especialista: " + VariaveisPodologo.nomePodologo);

                Console.WriteLine("\nNúmero do conselho/Registro Técnico do especialista: " + VariaveisPodologo.RegisTecPodologo);

                Console.WriteLine("\nEspecialidade profissional: " + VariaveisPodologo.EspecPodologo);

                Console.WriteLine("\nTelefone do especialista: " + VariaveisPodologo.TelefonePodologo);
                Thread.Sleep(5000);
            }
            if (cadastro == "Procedimento" || cadastro == "Serviço")
            {
                Console.Clear();
                Console.WriteLine("Aqui estão os dados de cadastro do procedimento/serviço: ");

                Console.WriteLine("\nID do procedimento/serviço: " + VariaveisProcedimento.IdProcedimento);

                Console.WriteLine("\nNome do procedimento/serviço: " + VariaveisProcedimento.nomeProcedimento);

                Console.WriteLine("\nTempo estimado do procedimento: " + VariaveisProcedimento.tempoProcedimento);

                Console.WriteLine("\nValor do procedimento: " + VariaveisProcedimento.valorProcedimento);
                Thread.Sleep(5000);
            }
            Console.WriteLine("\nGostaria de acessar outro cadastro?");
            resposta = Console.ReadLine();
            if (resposta != "s")
            {
                saida = true;
            }
        }


    }



}


