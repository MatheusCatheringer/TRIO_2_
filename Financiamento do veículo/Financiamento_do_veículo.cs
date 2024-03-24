using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiamento_do_veículo
{
    public class Financiamento
    {
        public static float Taxazero(float valor_veiculo, int num_parcelas)

        {
            float taxa_adm = (5 / 100) * valor_veiculo;

            return valor_veiculo + valor_veiculo + (num_parcelas * taxa_adm);
        }
        public static float TaxaFin(float valor_veiculo, int num_parcelas, float taxa_juros)
        {
            return valor_veiculo + valor_veiculo + (num_parcelas * (taxa_juros / 100));
        }
    }
}