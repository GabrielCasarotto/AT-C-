using System;
using System.IO;

namespace Exercicio9
{
    class Estoque
    {
        static string arquivo = "estoque.txt";

        public static void EX9()
        {
            Console.WriteLine("1 - Inserir | 2 - Listar");
            string op = Console.ReadLine();

            if (op == "1")
            {
                string[] produtos = File.Exists(arquivo) ? File.ReadAllLines(arquivo) : new string[0];
                if (produtos.Length >= 5) { Console.WriteLine("Limite de produtos atingido"); return; }

                Console.Write("Nome: "); string nome = Console.ReadLine();
                Console.Write("Qtd: "); string qtd = Console.ReadLine();
                Console.Write("Preço: "); string preco = Console.ReadLine();

                using (StreamWriter sw = File.AppendText(arquivo))
                    sw.WriteLine($"{nome},{qtd},{preco}");

                Console.WriteLine("Produto cadastrado");
            }
            else if (op == "2")
            {
                if (!File.Exists(arquivo) || new FileInfo(arquivo).Length == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado");
                    return;
                }

                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] d = linha.Split(',');
                        Console.WriteLine($"Produto: {d[0]} | Quantidade: {d[1]} | Preço: R$ {d[2]}");
                    }
                }
            }
        }
    }
}