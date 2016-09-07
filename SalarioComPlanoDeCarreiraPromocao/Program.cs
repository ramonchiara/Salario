using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioComPlanoDeCarreiraPromocao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível: ");
            int nivel = int.Parse(Console.ReadLine());
            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Tem promoção: ");
            string promocao = Console.ReadLine();

            // Processamento
            Funcionario funcionario = new Funcionario(nome, nivel, horas);
            decimal salario = funcionario.GetSalario();

            // Saída
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} (Nível {3}) e deve receber R$ {4}",
                funcionario.GetNome(), funcionario.GetHoras(), funcionario.GetValor(), funcionario.GetNivel(), salario);

            if (promocao == "s")
            {
                funcionario.Promover();
                salario = funcionario.GetSalario();

                Console.WriteLine("O funcionário {0} teve promoção, trabalhou {1} horas por R$ {2} (Nível {3}) e o seu novo salário é de R$ {4}",
                    funcionario.GetNome(), funcionario.GetHoras(), funcionario.GetValor(), funcionario.GetNivel(), salario);
            }
        }
    }
}
