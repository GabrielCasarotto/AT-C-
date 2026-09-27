using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    public class data
    {
        public static void EX4()
        {
            Console.Write("Digite sua data de nascimento: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            DateTime hoje = DateTime.Today;
            DateTime aniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

            if (aniversario < hoje) { aniversario = aniversario.AddYears(1); }

            int dias = (aniversario - hoje).Days;

            if (dias == 0)
            {
                Console.WriteLine("Parabéns! Hoje é o seu aniversário!");
            }
            else
            {
                Console.WriteLine($"Faltam {dias} dias para o seu aniversario");
                if (dias < 7) { Console.WriteLine("Seu aniversario está chegando, falta 1 semana......."); }
            }
        }
    }
}