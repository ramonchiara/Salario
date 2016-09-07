using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioComPlanoDeCarreira
{
    class Funcionario
    {
        private string Nome;
        private int Nivel;
        private double Horas;

        public Funcionario(string nome, int nivel, double horas)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.Horas = horas;
        }

        public decimal GetSalario()
        {
            decimal valor = GetValor();
            return valor * Convert.ToDecimal(Horas);
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
            decimal valor = 0;

            switch (Nivel)
            {
                case 1: valor = 15; break;
                case 2: valor = 18; break;
                case 3: valor = 22; break;
                case 4: valor = 27; break;
                case 5: valor = 33; break;
            }

            return valor;
        }

        public int GetNivel()
        {
            return Nivel;
        }
    }
}
