using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
   
    public class aluno
    {
        public String nome { get; set; }
        public String matricula { get; set; }
        public String curso { get; set; }
        public double mediaNotas { get; set; }

        public string VerificarAprovacao() => mediaNotas >= 7.0 ? "Aprovado" : "Reprovado";
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Nota média: {mediaNotas}");


        }
    }

    class resultado
    {
        public static void EX6()
        {
            aluno aluno = new aluno { nome = "Gabriel Casarotto", matricula = "123412367", curso = "ADS", mediaNotas = 8.5 };
            aluno.ExibirDados();
        }
    }
}
