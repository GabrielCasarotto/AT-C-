using Exercicio1;
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {

            Console.Clear();
            Console.WriteLine("________________________________________");
            Console.WriteLine("________________________________________");
            Console.WriteLine("MENU DE EXERCICIOS");
            Console.WriteLine("________________________________________");
            Console.WriteLine("________________________________________");

            Console.WriteLine("Exercício 1: Criando e Executando seu Primeiro Programa");
            Console.WriteLine("Exercício 2: Manipulação de Strings - Cifrador de Nome");
            Console.WriteLine("Exercício 3: Calculadora de Operações Matemáticas");
            Console.WriteLine("Exercício 4: Manipulação de Datas - Dias até o Próximo Aniversário");
            Console.WriteLine("Exercício 5: Tempo Restante para Conclusão do Curso - Diferença Entre Datas");
            Console.WriteLine("Exercício 6: Cadastro de Alunos");
            Console.WriteLine("Exercício 7: Banco Digital (Encapsulamento)");
            Console.WriteLine("Exercício 8: Cadastro de Funcionários (Herança)");
            Console.WriteLine("Exercício 9: Controle de Estoque via Linha de Comando");
            Console.WriteLine("Exercício 10: Jogo de Adivinhação");
            Console.WriteLine("Exercício 11: Manipulação de Arquivos - Cadastro e Listagem de Contatos");
            Console.WriteLine("Exercício 12: Manipulação de Arquivos com Herança e Polimorfismo - Formatos de Exibição");

            Console.WriteLine("________________________________________");
            Console.WriteLine("________________________________________");
            Console.Write("Escolha uma opção: ");

            String Opcao = Console.ReadLine();

            Console.Clear();

            switch (Opcao)
            {

                case "1":
                    Exercicio1.identidade.EX1();
                    Pausar();
                    break;
                case "2":
                    Exercicio2.Nome.EX2();
                    Pausar();
                    break;
                case "3":
                    Exercicio3.operacao.EX3();
                    Pausar();
                   break;
                case "4":
                    Exercicio4.data.EX4();
                    Pausar();
                    break;
                case "5":
                    Exercicio5.data.EX5();
                    Pausar();
                    break;
                case "6":
                    Exercicio6.resultado.EX6();
                    Pausar();
                    break;
                case "7":
                    Exercicio7.dadosBancarios.EX7();
                    Pausar();
                    break;
                case "8":
                    Exercicio8.empresa.EX8();
                    Pausar();
                    break;
                case "9":
                    Exercicio9.Estoque.EX9();
                    Pausar();
                    break;
                case "10":
                    Exercicio10.Jogo.EX10();
                    Pausar();
                    break;
                case "11":
                    Exercicio11.Contato.EX11();
                    Pausar();
                    break;
                case "12":
                    Exercicio12.gerenciador. EX12();
                   Pausar();
                    break;

            }

        }
    }

    static void Pausar()
    {
        Console.WriteLine("\nAperte qualquer tecla para retornar ao menu");
        Console.ReadKey();
    }
}