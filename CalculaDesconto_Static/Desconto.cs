using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public class Desconto
    {
        public static float PorcentagemValor(float valor_atual, float desconto)
        {
            return (valor_atual / 100) * (desconto);
        }

        public static float ValorFinal(float valor_atual, float desconto)
        {
            float valordesconto = PorcentagemValor(valor_atual, desconto);
            return (valor_atual - valordesconto);
        }
    }

}