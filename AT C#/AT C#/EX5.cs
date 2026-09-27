using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    public class data
    {
        public static void EX5()
        {
            DateTime dataFormatura = new DateTime(2026, 12, 15);

            Console.Write("Digite a data atual: ");
            DateTime dataAtual = DateTime.Parse(Console.ReadLine());

            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            if (dataAtual >= dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = dataFormatura.Year - dataAtual.Year;
            int meses = dataFormatura.Month - dataAtual.Month;
            int dias = dataFormatura.Day - dataAtual.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            string tempoFormatado = "";

            if (anos > 0)
            {
                tempoFormatado += $"{anos} ano{(anos > 1 ? "s" : "")}";
            }

            if (meses > 0)
            {
                if (tempoFormatado != "") tempoFormatado += ", ";
                tempoFormatado += $"{meses} mes{(meses > 1 ? "es" : "")}";
            }

            if (dias > 0)
            {
                if (tempoFormatado != "") tempoFormatado += " e ";
                tempoFormatado += $"{dias} dia{(dias > 1 ? "s" : "")}";
            }
            Console.WriteLine($"faltam {tempoFormatado} para sua formatura!");
            int totalMesesRestantes = (anos * 12) + meses;
            if (totalMesesRestantes < 6)
            {
                Console.WriteLine("A reta final chegou!prepare-se para a formatura!");
            }
        }
    }
}