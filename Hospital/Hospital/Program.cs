using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Internacao_Hospitalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░	██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗	██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║	██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║	██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║	██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝	╚═════╝░╚══════╝
 
██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░
 
██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Cadastrar médico");
                Console.WriteLine("3 - Cadastrar leito");
                Console.WriteLine("4 - Registrar Internação ");
                Console.WriteLine("5 - Dar Alta Hospitalar");
                Console.WriteLine("6 - Listar Pacientes Internados");
                Console.WriteLine("7 - Exibir Relatório Geral do Hospital");
                Console.WriteLine("8 - Sair");

                Console.ResetColor();
                Console.WriteLine("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Cadastro_Paciente();
                        break;
                    case 2:
                        Cadastro_medico();
                        break;
                    case 3:
                        Cadastro_leito();
                        break;
                    case 4:
                        Registro_internaçao();
                        break;
                    case 5:
                        Dar_alta();
                        break;
                    case 6:
                        Lista_de_internados();
                        break;
                    case 7:
                        Relatorio_geral();
                        break;
                    case 8:
                        Console.WriteLine("Saindo do programa...");
                        Thread.Sleep(1000);
                        break;

                }
            }

        }
        public static class VariaveisPaciente
        {
            public static int IdPaciente;
            public static DateTime DataNascimento;
            public static string NomePaciente, CPFpaciente, TipoSanguineo, Alergia, ContatoEmergencia;
        }
        static void Cadastro_Paciente()

        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
░█▀▀█ ─█▀▀█ ░█▀▀▄ ─█▀▀█ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ░█▀▀▀█ 　 ░█▀▀█ ─█▀▀█ ░█▀▀█ ▀█▀ ░█▀▀▀ ░█▄─░█ ▀▀█▀▀ ░█▀▀▀ 
░█─── ░█▄▄█ ░█─░█ ░█▄▄█ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█──░█ 　 ░█▄▄█ ░█▄▄█ ░█─── ░█─ ░█▀▀▀ ░█░█░█ ─░█── ░█▀▀▀ 
░█▄▄█ ░█─░█ ░█▄▄▀ ░█─░█ ░█▄▄▄█ ─░█── ░█─░█ ░█▄▄▄█ 　 ░█─── ░█─░█ ░█▄▄█ ▄█▄ ░█▄▄▄ ░█──▀█ ─░█── ░█▄▄▄");
                Console.ResetColor();

                Console.WriteLine("Digite o identificador do paciente:");
                VariaveisPaciente.IdPaciente = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome completo do paciente:");
                VariaveisPaciente.NomePaciente = Console.ReadLine();

                Console.WriteLine("Digite o cpf do paciente: ");
                VariaveisPaciente.CPFpaciente = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do paciente: ");
                VariaveisPaciente.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite o tipo sanguineo do paciente: ");
                VariaveisPaciente.TipoSanguineo = Console.ReadLine();

                Console.WriteLine("Digite se o paciente tem algum tipo de alergia: ");
                VariaveisPaciente.Alergia = Console.ReadLine();

                Console.WriteLine("Digite um contato de emergencia do paciente: ");
                VariaveisPaciente.ContatoEmergencia = Console.ReadLine();

                Console.WriteLine("Cadastro ralizado com sucesso: ");

                Console.WriteLine("Codigo do paciente: " + VariaveisPaciente.IdPaciente);
                Console.WriteLine("Nome completo: " + VariaveisPaciente.NomePaciente);
                Console.WriteLine("CPF: " + VariaveisPaciente.CPFpaciente);
                Console.WriteLine("Data de nascimento: " + VariaveisPaciente.DataNascimento);
                Console.WriteLine("Tipo sanguineo: " + VariaveisPaciente.TipoSanguineo);
                Console.WriteLine("Alergia: " + VariaveisPaciente.Alergia);
                Console.WriteLine("Contato de emergencia: " + VariaveisPaciente.ContatoEmergencia);
                Thread.Sleep(2000);
                Console.Clear();


                Console.WriteLine("Deseja fazer outro cadastro? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    continuar = false;
                }


            }


        }
        public static class VariaveisMedico
        {
            public static int IdMedico;
            public static string NomeMedico, CRMmedico, Especialidade, ContatoRapido;
        }
        static void Cadastro_medico()

        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
░█▀▀█ ─█▀▀█ ░█▀▀▄ ─█▀▀█ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ░█▀▀▀█ 　 ░█▀▄▀█ ░█▀▀▀ ░█▀▀▄ ▀█▀ ░█▀▀█ ░█▀▀▀█ 
░█─── ░█▄▄█ ░█─░█ ░█▄▄█ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█──░█ 　 ░█░█░█ ░█▀▀▀ ░█─░█ ░█─ ░█─── ░█──░█ 
░█▄▄█ ░█─░█ ░█▄▄▀ ░█─░█ ░█▄▄▄█ ─░█── ░█─░█ ░█▄▄▄█ 　 ░█──░█ ░█▄▄▄ ░█▄▄▀ ▄█▄ ░█▄▄█ ░█▄▄▄█");
                Console.ResetColor();

                Console.WriteLine("Digite o identificador do médico:");
                VariaveisMedico.IdMedico = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome completo do médico:");
                VariaveisMedico.NomeMedico = Console.ReadLine();

                Console.WriteLine("Digite o CRM do médico: ");
                VariaveisMedico.CRMmedico = Console.ReadLine();

                Console.WriteLine("Digite a especialidade do médico: ");
                VariaveisMedico.Especialidade = Console.ReadLine();

                Console.WriteLine("Digite um contato rapido do médico: ");
                VariaveisMedico.ContatoRapido = Console.ReadLine();

                Console.WriteLine("Cadastro ralizado com sucesso: ");

                Console.WriteLine("Codigo do médico: " + VariaveisMedico.IdMedico);
                Console.WriteLine("Nome completo: " + VariaveisMedico.NomeMedico);
                Console.WriteLine("CRM: " + VariaveisMedico.CRMmedico);
                Console.WriteLine("Especialidade: " + VariaveisMedico.Especialidade);
                Console.WriteLine("Contato rápido: " + VariaveisMedico.ContatoRapido);
                Thread.Sleep(2000);
                Console.Clear();


                Console.WriteLine("Deseja fazer outro cadastro? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    continuar = false;
                }


            }


        }
        public static class VariaveisLeito
        {
            public static int IdLeito;
            public static string NumLeito, TipoLeito;
            public static bool Ocupacao;
        }
        static void Cadastro_leito()

        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
░█▀▀█ ─█▀▀█ ░█▀▀▄ ─█▀▀█ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ░█▀▀▀█ 　 ░█▀▀▄ ░█▀▀▀█ 　 ░█─── ░█▀▀▀ ▀█▀ ▀▀█▀▀ ░█▀▀▀█ 
░█─── ░█▄▄█ ░█─░█ ░█▄▄█ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█──░█ 　 ░█─░█ ░█──░█ 　 ░█─── ░█▀▀▀ ░█─ ─░█── ░█──░█ 
░█▄▄█ ░█─░█ ░█▄▄▀ ░█─░█ ░█▄▄▄█ ─░█── ░█─░█ ░█▄▄▄█ 　 ░█▄▄▀ ░█▄▄▄█ 　 ░█▄▄█ ░█▄▄▄ ▄█▄ ─░█── ░█▄▄▄█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Digite o identificador do leito: ");
                VariaveisLeito.IdLeito = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero ou codigo do quarto: ");
                VariaveisLeito.NumLeito = Console.ReadLine();

                Console.WriteLine("Digite o tipo do leito (ex:enfermaria, apartamento,UTI): ");
                VariaveisLeito.TipoLeito = Console.ReadLine();

                Console.WriteLine("Digite se esta disponivel(true para indisponivel, false para disponivel): ");
                VariaveisLeito.Ocupacao = bool.Parse(Console.ReadLine());

                Console.WriteLine("Cadastro ralizado com sucesso: ");

                Console.WriteLine("Codigo do leito: " + VariaveisLeito.IdLeito);
                Console.WriteLine("Numero ou codigo do quarto: " + VariaveisLeito.NumLeito);
                Console.WriteLine("Tipo do leito: " + VariaveisLeito.TipoLeito);
                Console.WriteLine("Ocupação:    " + VariaveisLeito.Ocupacao);
                Thread.Sleep(2000);
                Console.Clear();


                Console.WriteLine("Deseja fazer outro cadastro? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    continuar = false;
                }


            }


        }

        static void Registro_internaçao()

        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
░█▀▀█ ░█▀▀▀ ░█▀▀█ ▀█▀ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ─█▀▀█ ░█▀▀█ 　 ▀█▀ ░█▄─░█ ▀▀█▀▀ ░█▀▀▀ ░█▀▀█ ░█▄─░█ ─█▀▀█ ░█▀▀█ ─█▀▀█ ░█▀▀▀█ 
░█▄▄▀ ░█▀▀▀ ░█─▄▄ ░█─ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█▄▄█ ░█▄▄▀ 　 ░█─ ░█░█░█ ─░█── ░█▀▀▀ ░█▄▄▀ ░█░█░█ ░█▄▄█ ░█─── ░█▄▄█ ░█──░█ 
░█─░█ ░█▄▄▄ ░█▄▄█ ▄█▄ ░█▄▄▄█ ─░█── ░█─░█ ░█─░█ ░█─░█ 　 ▄█▄ ░█──▀█ ─░█── ░█▄▄▄ ░█─░█ ░█──▀█ ░█─░█ ░█▄▄█ ░█─░█ ░█▄▄▄█");
                Console.ResetColor();

                Console.WriteLine("Digite o identificador da internação:");
                Variaveis.id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo do paciente:");
                Variaveis.codpaci = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo do medico: ");
                Variaveis.codmed = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo do leito: ");
                Variaveis.codleito = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de entrada na internação ");
                Variaveis.dtentrada = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite o motivo da internação: ");
                Variaveis.motivo = Console.ReadLine();

                Console.WriteLine("Digite o status da internaçao(ex: 'internado', 'alta concluida' ou 'transferido'): ");
                string stts = Console.ReadLine();

                if (stts == "alta concluida" || stts == "transferido")
                {
                    Console.WriteLine("Digite a data de saida da internação: ");
                    DateTime dtsaida = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Codigo da internação: " + Variaveis.id);
                    Console.WriteLine("Codigo do paciente: " + Variaveis.codpaci);
                    Console.WriteLine("Codigo do medico: " + Variaveis.codmed);
                    Console.WriteLine("Codigo do leito: " + Variaveis.codleito);
                    Console.WriteLine("Data de entrada: " + Variaveis.dtentrada);
                    Console.WriteLine("Motivo da internação: " + Variaveis.motivo);
                    Console.WriteLine("Status da internação: " + Variaveis.stts);
                    Console.WriteLine("Data de saída: " + Variaveis.dtsaida);


                }

                if (stts == "internado")
                {

                    Console.WriteLine("Codigo da internação: " + Variaveis.id);
                    Console.WriteLine("Codigo do paciente: " + Variaveis.codpaci);
                    Console.WriteLine("Codigo do medico: " + Variaveis.codmed);
                    Console.WriteLine("Codigo do leito: " + Variaveis.codleito);
                    Console.WriteLine("Data de entrada: " + Variaveis.dtentrada);
                    Console.WriteLine("Motivo da internação: " + Variaveis.motivo);
                    Console.WriteLine("Status da internação: " + Variaveis.stts);
                }
                Thread.Sleep(2000);
                Console.Clear();


                Console.WriteLine("Deseja fazer outro cadastro? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    continuar = false;
                }


            }

        }
        public static class VariaveisAlta
        {
            public static int idalta, codinterna, codpacie;
            public static string codquarto, codmedi;

        }
        static void Dar_alta()

        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
─█▀▀█ ░█─── ▀▀█▀▀ ─█▀▀█ 　 ░█─░█ ░█▀▀▀█ ░█▀▀▀█ ░█▀▀█ ▀█▀ ▀▀█▀▀ ─█▀▀█ ░█─── ─█▀▀█ ░█▀▀█ 
░█▄▄█ ░█─── ─░█── ░█▄▄█ 　 ░█▀▀█ ░█──░█ ─▀▀▀▄▄ ░█▄▄█ ░█─ ─░█── ░█▄▄█ ░█─── ░█▄▄█ ░█▄▄▀ 
░█─░█ ░█▄▄█ ─░█── ░█─░█ 　 ░█─░█ ░█▄▄▄█ ░█▄▄▄█ ░█─── ▄█▄ ─░█── ░█─░█ ░█▄▄█ ░█─░█ ░█─░█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Digite o identificador da alta: ");
                VariaveisAlta.idalta = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo da internação: ");
                VariaveisAlta.codinterna = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo do paciente: ");
                VariaveisAlta.codpacie = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o codigo do quarto: ");
                VariaveisAlta.codquarto = Console.ReadLine();

                Console.WriteLine("Digite o codigo do medico responsavel: ");
                VariaveisAlta.codmedi = Console.ReadLine();


                Console.WriteLine("Alta hospitalar realizada com sucesso: ");

                Console.WriteLine("Codigo da alta: " + VariaveisAlta.idalta);
                Console.WriteLine("Codigo da internação: " + VariaveisAlta.codinterna);
                Console.WriteLine("Codigo do paciente: " + VariaveisAlta.codpacie);
                Console.WriteLine("Codigo do quarto: " + VariaveisAlta.codquarto);
                Console.WriteLine("Codigo do medico responsavel: " + VariaveisAlta.codmedi);

                Thread.Sleep(2000);
                Console.Clear();


                Console.WriteLine("Deseja dar alta para outro paciente? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    continuar = false;
                }


            }

        }
        public static class Variaveis
        {
            public static int id, codpaci, codmed, codleito;
            public static DateTime dtentrada, dtsaida;
            public static string motivo;
            public static string stts;
        }


        static void Lista_de_internados()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
░█─── ▀█▀ ░█▀▀▀█ ▀▀█▀▀ ─█▀▀█ 　 ░█▀▀▄ ░█▀▀▀ 　 ▀█▀ ░█▄─░█ ▀▀█▀▀ ░█▀▀▀ ░█▀▀█ ░█▄─░█ ─█▀▀█ ░█▀▀▄ ░█▀▀▀█ ░█▀▀▀█ 
░█─── ░█─ ─▀▀▀▄▄ ─░█── ░█▄▄█ 　 ░█─░█ ░█▀▀▀ 　 ░█─ ░█░█░█ ─░█── ░█▀▀▀ ░█▄▄▀ ░█░█░█ ░█▄▄█ ░█─░█ ░█──░█ ─▀▀▀▄▄ 
░█▄▄█ ▄█▄ ░█▄▄▄█ ─░█── ░█─░█ 　 ░█▄▄▀ ░█▄▄▄ 　 ▄█▄ ░█──▀█ ─░█── ░█▄▄▄ ░█─░█ ░█──▀█ ░█─░█ ░█▄▄▀ ░█▄▄▄█ ░█▄▄▄█");
            Console.ResetColor();


            if (Variaveis.stts == "internado")
            {
                Console.WriteLine("Aqui estão os dados de pacientes internados: ");
                Console.WriteLine("Codigo da internação: " + Variaveis.id);
                Console.WriteLine("Codigo do paciente: " + Variaveis.codpaci);
                Console.WriteLine("Codigo do medico: " + Variaveis.codmed);
                Console.WriteLine("Codigo do leito: " + Variaveis.codleito);
                Console.WriteLine("Data de entrada: " + Variaveis.dtentrada);
                Console.WriteLine("Motivo da internação: " + Variaveis.motivo);
                Console.WriteLine("Status da internação: " + Variaveis.stts);
            }

            else
            {
                Console.WriteLine("Não há pacientes internados.");


            }
            Thread.Sleep(3000);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadLine();

        }
        static void Relatorio_geral()
        {
            bool continuar = true;
            while (continuar)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
██████╗░███████╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░██╗░█████╗░
██╔══██╗██╔════╝██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗
██████╔╝█████╗░░██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝██║██║░░██║
██╔══██╗██╔══╝░░██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗██║██║░░██║
██║░░██║███████╗███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║██║╚█████╔╝
╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░
 
░██████╗░███████╗██████╗░░█████╗░██╗░░░░░	██████╗░░█████╗░
██╔════╝░██╔════╝██╔══██╗██╔══██╗██║░░░░░	██╔══██╗██╔══██╗
██║░░██╗░█████╗░░██████╔╝███████║██║░░░░░	██║░░██║██║░░██║
██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░░░░	██║░░██║██║░░██║
╚██████╔╝███████╗██║░░██║██║░░██║███████╗	██████╔╝╚█████╔╝
░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝	╚═════╝░░╚════╝░
 
██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█ █▀   █▀▄ █▀▀   █▀█ ▄▀█ █▀▀ █ █▀▀ █▄░█ ▀█▀ █▀▀ █▀   █▀█ █▀▀ ▄▀█ █░░ █ ▀█ ▄▀█ █▀▄ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█ ▄█   █▄▀ ██▄   █▀▀ █▀█ █▄▄ █ ██▄ █░▀█ ░█░ ██▄ ▄█   █▀▄ ██▄ █▀█ █▄▄ █ █▄ █▀█ █▄▀ █▄█ ▄█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Codigo do paciente: " + VariaveisPaciente.IdPaciente);
                Console.WriteLine("Nome completo: " + VariaveisPaciente.NomePaciente);
                Console.WriteLine("CPF: " + VariaveisPaciente.CPFpaciente);
                Console.WriteLine("Data de nascimento: " + VariaveisPaciente.DataNascimento);
                Console.WriteLine("Tipo sanguineo: " + VariaveisPaciente.TipoSanguineo);
                Console.WriteLine("Alergia: " + VariaveisPaciente.Alergia);
                Console.WriteLine("Contato de emergencia: " + VariaveisPaciente.ContatoEmergencia);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█ █▀   █▀▄ █▀▀   █▀▄▀█ █▀▀ █▀▄ █ █▀▀ █▀█ █▀   █▀█ █▀▀ ▄▀█ █░░ █ ▀█ ▄▀█ █▀▄ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█ ▄█   █▄▀ ██▄   █░▀░█ ██▄ █▄▀ █ █▄▄ █▄█ ▄█   █▀▄ ██▄ █▀█ █▄▄ █ █▄ █▀█ █▄▀ █▄█ ▄█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Codigo do médico: " + VariaveisMedico.IdMedico);
                Console.WriteLine("Nome completo: " + VariaveisMedico.NomeMedico);
                Console.WriteLine("CRM: " + VariaveisMedico.CRMmedico);
                Console.WriteLine("Especialidade: " + VariaveisMedico.Especialidade);
                Console.WriteLine("Contato rápido: " + VariaveisMedico.ContatoRapido);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█ █▀   █▀▄ █▀▀   █░░ █▀▀ █ ▀█▀ █▀█ █▀   █▀█ █▀▀ ▄▀█ █░░ █ ▀█ ▄▀█ █▀▄ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█ ▄█   █▄▀ ██▄   █▄▄ ██▄ █ ░█░ █▄█ ▄█   █▀▄ ██▄ █▀█ █▄▄ █ █▄ █▀█ █▄▀ █▄█ ▄█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Codigo do leito: " + VariaveisLeito.IdLeito);
                Console.WriteLine("Numero ou codigo do quarto: " + VariaveisLeito.NumLeito);
                Console.WriteLine("Tipo do leito: " + VariaveisLeito.TipoLeito);
                Console.WriteLine("Ocupação:    " + VariaveisLeito.Ocupacao);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
▄▀█ █░░ ▀█▀ ▄▀█ █▀   █░█ █▀█ █▀ █▀█ █ ▀█▀ ▄▀█ █░░ ▄▀█ █▀█ █▀▀ █▀   █▀█ █▀▀ ▄▀█ █░░ █ ▀█ ▄▀█ █▀▄ ▄▀█ █▀
█▀█ █▄▄ ░█░ █▀█ ▄█   █▀█ █▄█ ▄█ █▀▀ █ ░█░ █▀█ █▄▄ █▀█ █▀▄ ██▄ ▄█   █▀▄ ██▄ █▀█ █▄▄ █ █▄ █▀█ █▄▀ █▀█ ▄█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Codigo da alta: " + VariaveisAlta.idalta);
                Console.WriteLine("Codigo da internação: " + VariaveisAlta.codinterna);
                Console.WriteLine("Codigo do paciente: " + VariaveisAlta.codpacie);
                Console.WriteLine("Codigo do quarto: " + VariaveisAlta.codquarto);
                Console.WriteLine("Codigo do medico responsavel: " + VariaveisAlta.codmedi);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
█▀█ ▄▀█ █▀▀ █ █▀▀ █▄░█ ▀█▀ █▀▀ █▀   █ █▄░█ ▀█▀ █▀▀ █▀█ █▄░█ ▄▀█ █▀▄ █▀█ █▀
█▀▀ █▀█ █▄▄ █ ██▄ █░▀█ ░█░ ██▄ ▄█   █ █░▀█ ░█░ ██▄ █▀▄ █░▀█ █▀█ █▄▀ █▄█ ▄█");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Codigo da internação: " + Variaveis.id);
                Console.WriteLine("Codigo do paciente: " + Variaveis.codpaci);
                Console.WriteLine("Codigo do medico: " + Variaveis.codmed);
                Console.WriteLine("Codigo do leito: " + Variaveis.codleito);
                Console.WriteLine("Data de entrada: " + Variaveis.dtentrada);
                Console.WriteLine("Motivo da internação: " + Variaveis.motivo);
                Console.WriteLine("Status da internação: " + Variaveis.stts);


                Console.WriteLine("Digite (s) para sair");
                Console.ReadLine();
                


            }
        }
    }
}
