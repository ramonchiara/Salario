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
            Funcionario funcionario = new Funcionario(nome); // OPTEI por usar esse construtor
            funcionario.SetNivel(nivel); // DESSA FORMA, preciso colocar o nivel que o usuário entrou usando um método modificador (Set)
            decimal salario = funcionario.GetSalario(horas); // e, OPTEI por passar as horas que o usuário entrou para o método de domínio

            // Saída
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} (Nível {3}) e deve receber R$ {4}",
                funcionario.GetNome(), horas, funcionario.GetValor(), funcionario.GetNivel(), salario);
            // ATENÇÃO aqui -------------^ você sabe me dizer o porquê de eu não poder pedir para o funcionário as horas aqui?

            if (promocao == "s")
            {
                funcionario.Promover();
                funcionario.SetHoras(horas); // aqui, OPTEI, por passar as horas usando um método modificador (Set)
                salario = funcionario.GetSalario(); // ASSIM, posso chamar o método de domínio sem parâmetros

                Console.WriteLine("O funcionário {0} teve promoção, trabalhou {1} horas por R$ {2} (Nível {3}) e o seu novo salário é de R$ {4}",
                    funcionario.GetNome(), funcionario.GetHoras(), funcionario.GetValor(), funcionario.GetNivel(), salario);
            }
        }
    }
}
