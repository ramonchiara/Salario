using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioPorHora
{
    class Funcionario
    {
        private string Nome;
        private decimal Valor;
        private double Horas;

        public Funcionario(string nome, decimal valor, double horas)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Horas = horas;
        }

        public decimal GetSalario()
        {
            return Valor * Convert.ToDecimal(Horas);
        }

        public string GetNome()
        {
            return Nome;
        }

        public double GetHoras()
        {
            return Horas;
        }

        public decimal GetValor()
        {
            return Valor;
        }
    }
}
