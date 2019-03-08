using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo2Numeros.Modelo
{
    public class Validacao
    {
        public string num1;
        public string num2;
        public double n1;
        public double n2;
        public string mensagem;

        public void Validar()
        {
            this.mensagem = "";
            try
            {
                this.n1 = Convert.ToDouble(this.num1);
                this.n2 = Convert.ToDouble(this.num2);
            }
            catch (FormatException)
            {
                this.mensagem = "Número inválido";
            }
        }
    }
}
