using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1403
{
    class E2_Pessoa
    {
        private string nome;
        private string sexo;
        private double salariobase;
        private int ndependentes;
        private double salariofamilia;

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Salariobase { get => salariobase; set => salariobase = value; }
        public int Ndependentes { get => ndependentes; set => ndependentes = value; }
        public double Salariofamilia { get => salariofamilia; set => salariofamilia = value; }




        public E2_Pessoa() { }

        public E2_Pessoa(string NOME)
        {
            nome = NOME;
        }



        public E2_Pessoa(string NOME, string SEXO, double S_BASE, int N_DEPENDENTES)
        {
            Nome = NOME;
            Sexo = SEXO;
            Salariobase = S_BASE;
            Ndependentes = N_DEPENDENTES;
        }


        public E2_Pessoa(double SALARIO_BASE, int N_DEPENDENTES)
        {
            salariobase = SALARIO_BASE;
            Ndependentes = N_DEPENDENTES;

        }

        public double SalarioFamilia()
        {
            salariofamilia = salariobase * 0.5 * ndependentes;
            return Salariofamilia;
        }



        public string MostrarDados()
        {
            return ("Nome: " + nome + "\n" + "Número de Dependentes: " + ndependentes + "\n" +
             "Salário Base: " + salariobase + "\n" + "Salário Família: " + salariofamilia);
        }
    }
}
