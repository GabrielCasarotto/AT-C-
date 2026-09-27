using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio12
{
    public class contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    public class ContatoFormatter
    {
        public virtual void ExibirContatos(List<contato> contatos)
        {
            Console.WriteLine("Exibindo contatos");
        }
    }

    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<contato> contatos)
        {
            Console.WriteLine("Lista de Contatos");
            foreach (var c in contatos)
            {
                Console.WriteLine($"Nome: {c.Nome}");
                Console.WriteLine($"Telefone: {c.Telefone}");
                Console.WriteLine($"Email: {c.Email}");
            }
        }
    }
    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<contato> contatos)
        {
            Console.WriteLine("| {0,-20} | {0,-18} | {0,-22} |", "Nome", "Telefone", "Email");
            foreach (var c in contatos)
            {
                Console.WriteLine("| {0,-20} | {1,-18} | {2,-22} |", c.Nome, c.Telefone, c.Email);
            }
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<contato> contatos)
        {
            foreach (var c in contatos)
            {
                Console.WriteLine($"Nome: {c.Nome} | Telefone: {c.Telefone} | Email: {c.Email}");
            }
        }
    }

    public class gerenciador
    {
        private static readonly string arquivo = "contatos.txt";

        public static void EX12()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Adicionar Novo Contato");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("3 - Voltar");
                Console.Write("Escolha uma opção: ");

                string op = Console.ReadLine();

                if (op == "1") Cadastrar();
                else if (op == "2") ListarComFormatador();
                else if (op == "3") return;

                Pausar();
            }
        }

        private static void Cadastrar()
        {
            Console.Clear();
            Console.Write("Nome: "); string nome = Console.ReadLine();
            Console.Write("Telefone: "); string tel = Console.ReadLine();
            Console.Write("Email: "); string email = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(arquivo))
            {
                sw.WriteLine($"{nome},{tel},{email}");
            }
            Console.WriteLine("Contato cadastradoo");
        }

        private static void ListarComFormatador()
        {
            Console.Clear();

            if (!File.Exists(arquivo) || new FileInfo(arquivo).Length == 0)
            {
                Console.WriteLine("nenhum contato cadastrado.");
                return;
            }

            List<contato> lista = new List<contato>();
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] d = linha.Split(',');
                    if (d.Length == 3) lista.Add(new contato(d[0], d[1], d[2]));
                }
            }

            Console.WriteLine("Escolha o formato de exibição:");
            Console.WriteLine("1 - Markdown");
            Console.WriteLine("2 - Tabela");
            Console.WriteLine("3 - Texto Puro");
            Console.Write("Opção: ");
            string f = Console.ReadLine();

            Console.Clear();

            ContatoFormatter formatter;

            switch (f)
            {
                case "1":
                    formatter = new MarkdownFormatter();
                    break;
                case "2":
                    formatter = new TabelaFormatter();
                    break;
                default:
                    formatter = new RawTextFormatter();
                    break;
            }

            formatter.ExibirContatos(lista);
        }

        private static void Pausar()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}