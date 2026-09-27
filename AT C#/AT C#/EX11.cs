using System;
using System.IO;

namespace Exercicio11
{
    class Contato
    {
        private static readonly string arquivo = "contatos.txt";

        public static void EX11()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Gerenciador de Contatos: ");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        Pausar();
                        break;
                    case "2":
                        ListarContatos();
                        Pausar();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        private static void AdicionarContato()
        {
            Console.Clear();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            try
            {
                using (StreamWriter sw = File.AppendText(arquivo))
                {
                    sw.WriteLine($"{nome},{telefone},{email}");
                }
                Console.WriteLine("\nContato cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro ao salvar contato: {ex.Message}");
            }
        }

        private static void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("Contatos cadastrados:\n");

            if (!File.Exists(arquivo) || new FileInfo(arquivo).Length == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linha)) continue;

                        string[] dados = linha.Split(',');
                        if (dados.Length == 3)
                        {
                            Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler contatos: {ex.Message}");
            }
        }

        private static void Pausar()
        {
            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}