using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioPorHora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor: ");
            decimal valor = int.Parse(Console.ReadLine());
            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());

            // Processamento
            Funcionario funcionario = new Funcionario(nome, valor, horas);
            decimal salario = funcionario.GetSalario();

            // Saída
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} e deve receber R$ {3}",
                funcionario.GetNome(), funcionario.GetHoras(), funcionario.GetValor(), salario);
        }
    }
}
