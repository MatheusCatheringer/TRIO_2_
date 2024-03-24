using Calculadesconto_return;
public class Desconto_Retorno {
     public static void Main()
    {
        Console.WriteLine("Calculadora de Desconto");
        Console.WriteLine("Informe o valor");
        float valor_atual = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a porcentagem de desconto");
        float desconto = float.Parse(Console.ReadLine());
        Desconto_Return instancia_desconto = new Desconto_Return();
        Console.WriteLine($"o valor de desconto é {instancia_desconto.PorcentagemValor(valor_atual, desconto)}");
        Console.WriteLine($"o valor final é {instancia_desconto.ValorFinal(valor_atual, desconto)}");
    }       
}

   