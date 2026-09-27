using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private decimal saldo; 

        public ContaBancaria(string titular) => Titular = titular;

        public void Depositar(decimal valor)
        {
            if (valor > 0) { saldo += valor; Console.WriteLine($"Depósito de {valor:C2} realizado com sucesso!"); }
            else { Console.WriteLine("O valor do depósito deve ser positivo"); }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo) { saldo -= valor; Console.WriteLine($"Saque de {valor:C2} realizado com sucesso!"); }
            else { Console.WriteLine("Saldo insuficiente para realizar o saque!"); }
        }

        public void ExibirSaldo() { Console.WriteLine($"Saldo atual: {saldo:C2}"); }
    }

    class dadosBancarios
    {
        public static void EX7()
        {
            var conta = new ContaBancaria("Joao silva");
            Console.WriteLine($"Titular: {conta.Titular}");

            conta.Depositar(500.00m);
            conta.ExibirSaldo();

            Console.WriteLine("Tentativa de saque: R$ 700,00");
            conta.Sacar(700.00m);

            conta.Sacar(200.00m);
            conta.ExibirSaldo();
        }
    }
}
