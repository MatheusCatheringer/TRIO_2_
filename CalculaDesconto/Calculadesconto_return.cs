﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadesconto_return

{
    public class Desconto_Return
    {

        public float PorcentagemValor(float valor_atual, float desconto)
        {
            return (valor_atual / 100) * (desconto);
        }

        public float ValorFinal(float valor_atual, float desconto)
        {
            float valordesconto = PorcentagemValor(valor_atual, desconto);
            return (valor_atual - valordesconto);
        }
    }

}