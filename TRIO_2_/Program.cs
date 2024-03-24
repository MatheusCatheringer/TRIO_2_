// See https://aka.ms/new-console-template for more information

using System;
using Calculadesconto_return;
using CalculaDesconto;
using Financiamento_do_veículo;


bool entrada = true;
    do
    {
    try
    {

        Console.WriteLine("MENU");
        Console.WriteLine("Selecione a atividade desejada");
        Console.WriteLine("1- Calcula Desconto: Método com retorno");
        Console.WriteLine("2- Calcula Desconto: Método  estático");
        Console.WriteLine("3-Financiamento do veículo: Método com retorno");

        int seleção = int.Parse(Console.ReadLine());
        if (seleção == 1)
        {
            Desconto_Retorno.Main();
        }
        else if (seleção == 2)
        {
            Desconto_Static.Main();
        }

        else if (seleção == 3)
        {
            Finaciamento_Static.Main();
        }
        else {Console.WriteLine("Selecine valores inteiros de 1 a 3"); }
        
    }
    catch (FormatException) { Console.WriteLine("Selecine valores inteiros de 1 a 3 No MENU");
        Console.WriteLine("Para opção 1 insira valores tipo float");
        Console.WriteLine("Para opção 2 insira valores tipo float");
        Console.WriteLine("Para opção 3 insira valores float em preços dos veiculo e int para numero de parcelas");
    }
  
} while (entrada);

