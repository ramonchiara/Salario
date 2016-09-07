using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioComPlanoDeCarreiraPromocao
{
    class Funcionario
    {
        private string Nome;
        private int Nivel;
        private double Horas;

        public Funcionario(string nome) : this(nome, 1, 160)
        {
        }

        public Funcionario(string nome, double horas) : this(nome, 1, horas)
        {
        }

        public Funcionario(string nome, int nivel) : this(nome, nivel, 160)
        {
        }

        public Funcionario(string nome, int nivel, double horas)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.Horas = horas;
        }

        public decimal GetSalario()
        {
            return GetSalario(Horas);
        }

        public decimal GetSalario(double horas)
        {
            decimal valor = GetValor();
            return valor * Convert.ToDecimal(horas);
        }

        public string GetNome()
        {
            return Nome;
        }

        public double GetHoras()
        {
            return Horas;
        }

        public void SetHoras(double horas)
        {
            if (horas > 0)
            {
                Horas = horas;
            }
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

        public void SetNivel(int nivel)
        {
            if (nivel >= 1 && nivel <= 5)
            {
                Nivel = nivel;
            }
        }

        public void Promover()
        {
            if (Nivel < 5)
            {
                Nivel = Nivel + 1;
            }
        }
    }
}

