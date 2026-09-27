using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        public Funcionario(string nome, string cargo, decimal salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }
        public virtual decimal CalcularSalario() => SalarioBase;

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {CalcularSalario()}");
        }
    }
    class Gerente : Funcionario
    {

        public Gerente(string nome, decimal salarioBase)
            : base(nome, "Gerente", salarioBase) { }

        public override decimal CalcularSalario() => SalarioBase * 1.20m;
    }

    class empresa
    {
        public static void EX8()
        {
            Funcionario f1 = new Funcionario("Ana teste", "Desenvolvedora", 5000.00m);
            f1.ExibirDados();

            Gerente g1 = new Gerente("João teste.", 8000.00m);
            g1.ExibirDados();
        }
    }
}
