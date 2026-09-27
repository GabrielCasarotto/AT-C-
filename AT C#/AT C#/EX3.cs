using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class operacao {

        public static void EX3() {

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
			int n2 = int.Parse(Console.ReadLine());

			Console.WriteLine("________________________________________");
			Console.WriteLine("________________________________________");
			Console.WriteLine("Digite o número para a operação Desejada: ");
			Console.WriteLine("________________________________________");
			Console.WriteLine("________________________________________");
			Console.WriteLine("1 - Soma");
			Console.WriteLine("2 - Subtração");
			Console.WriteLine("3 - Multiplicação");
			Console.WriteLine("4 - Divisão");
			Console.WriteLine("________________________________________");
			Console.WriteLine("________________________________________");

			int opcao = int.Parse(Console.ReadLine());

			int resultado = 0;

			switch (opcao) {

				case 1:
					resultado = n1 + n2;
					break;

				case 2:
					resultado = n1 - n2;
					break;

				case 3:
					resultado = n1 * n2;
					break;

				case 4:
					if (n1 != 0) { resultado = n1 / n2; } else { Console.WriteLine("Não é possivel dividir por 0"); return; }
					
					break;

				default: Console.WriteLine("Opção Inválida"); return;
			}

			Console.WriteLine($"O resultado é {resultado}");

		}
    
    }
}
