using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public class Nome
    {
        public static void EX2()
        {
            Console.Write("Digite seu nome: ");
            char[] n = Console.ReadLine().ToCharArray();

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 'A' && n[i] <= 'Z') n[i] = (char)('A' + (n[i] - 'A' + 2) % 26);
                else if (n[i] >= 'a' && n[i] <= 'z') n[i] = (char)('a' + (n[i] - 'a' + 2) % 26);
            }

            Console.WriteLine("Saída: " + new string(n));
        }
    }
}
