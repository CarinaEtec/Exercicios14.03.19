using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1403
{
    class E4_Rolezinho
    {
        private String filme;
        private int nsala;
        private String diasemana;
        private double preco;
        private double desconto;

        public string Filme { get => filme; set => filme = value; }
        public int Nsala { get => nsala; set => nsala = value; }
        public string Diasemana { get => diasemana; set => diasemana = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Desconto { get => desconto; set => desconto = value; }




        public E4_Rolezinho(String DIASEMANA, double PRECO)
        {
            diasemana = DIASEMANA;
            preco = PRECO;
        }


        public void Verificar()
        {
            if (this.diasemana == "Quarta" || this.diasemana == "quarta" || this.diasemana == "QUARTA")
            {
                this.desconto = this.preco * 0.5;

            }
            else
            {
                this.desconto = this.preco;
            }
        }



    }
}