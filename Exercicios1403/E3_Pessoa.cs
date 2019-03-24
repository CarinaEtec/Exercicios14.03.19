using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1403
{
    class E3_Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private double peso;
        private string sexo;
        private double imc;
        private string condicao;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Imc { get => imc; set => imc = value; }
        public string Condicao { get => condicao; set => condicao = value; }

        public E3_Pessoa(double ALTURA, double PESO)
        {
            altura = ALTURA;
            peso = PESO;
        }



        public void Calcular()
        {
            this.imc = this.peso / (this.altura * this.altura);


            if (this.imc < 17)
            {
                this.condicao = "muito abaixo do peso";
            }

            else if (this.imc >= 17 && this.imc <= 18.49)
            {
                this.condicao = "abaixo do peso";
            }
            else if (this.imc >= 18.5 && this.imc <= 24.99)
            {
                this.condicao = "peso normal";
            }

            else if (this.imc >= 25 && this.imc <= 29.99)
            {
                this.condicao = "acima do peso";
            }
            else if (this.imc >= 30 && this.imc <= 34.99)
            {
                this.condicao = "Obesidade I";
            }
            else if (this.imc >= 35 && this.imc <= 39.99)
            {
                this.condicao = "Obesidade II(severa)";
            }
            else
            {
                this.condicao = "Obesidade III(mórbida)";
            }
        }
    }
}
