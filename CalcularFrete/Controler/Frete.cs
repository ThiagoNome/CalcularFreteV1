using CalcularFrete.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete.Controler
{
    internal class Frete
    {
        private decimal valor;
        private decimal frete;
        private string UF;
        public Frete() 
        {

        }

        public decimal Calcular(string uF, decimal v)
        {
            this.UF = uF;
            this.valor = v;
            this.frete = 0;

            switch (UF)
            {
                case "SP": this.frete = 0.11m; break;
                case "RJ": this.frete = 0.07m; break;
                case "BA": this.frete = 0.08m; break;
                case "MG": this.frete = 0.08m; break;
                case "PE": this.frete = 0.09m; break;
                case "PA": this.frete = 0.010m; break;
                case "RS": this.frete = 0.10m; break;

            }
            valor = frete * valor;
                
            return valor;
        }

        public string LimparTela () 
        {
            return "OK";
        }

    }
}
