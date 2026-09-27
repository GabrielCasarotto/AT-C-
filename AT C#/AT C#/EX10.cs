using System;

namespace Exercicio10
{
    class Jogo
    {
        public static void EX10()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);
            int tentativas = 5;
            Console.WriteLine("Adivinhe o número secreto de 1 a 50!");

            for (int i = 1; i <= tentativas; i++)
            {
                Console.Write($"\nTentativa {i}/{tentativas} - Digite seu palpite: ");

                try
                {
                    int palpite = int.Parse(Console.ReadLine());

                    if (palpite < 1 || palpite > 50)
                    {
                        Console.WriteLine("Erro: O número deve estar entre 1 e 50");
                        i--;
                        continue;
                    }

                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine($"\nParabéns! Você acertou em {i} tentativa(s)!");
                        return;
                    }

                    if (palpite < numeroSecreto)
                        Console.WriteLine("O número secreto é MAIOR!");
                    else
                        Console.WriteLine("O número secreto é MENOR!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Digite apenas numeros inteiros valido");
                    i--;
                }
            }

            Console.WriteLine($"Fim de jogo! Você perdeu. O número era: {numeroSecreto}");
        }
    }
}