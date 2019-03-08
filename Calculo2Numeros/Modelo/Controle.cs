using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo2Numeros.Modelo
{
    public class Controle
    {
        public string num1;
        public string num2;
        public string resultado;
        public string mensagem;

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.num1 = this.num1;
            validacao.num2 = this.num2;
            validacao.Validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculo calculo = new Calculo();
                calculo.n1 = validacao.n1;
                calculo.n2 = validacao.n2;
                calculo.Somar();
                this.resultado = calculo.res.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
