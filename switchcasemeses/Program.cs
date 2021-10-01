using System;

namespace switchcasemeses
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 5;

        Console.WriteLine("Por favor, insira o número que representa o mês desejado");
        Console.ReadLine();

        switch (mes)
        {
   
       case 1:
       Console.Write("Esse mês tem 31 dias");
        break;

       case 2:
       Console.Write("Esse mês tem 28 em anos regulares e 29 dias em anos bissextos");
        break;

       case 3:
       Console.Write("Esse mês tem 31 dias");
        break;

       case 5:
       Console.Write("Esse mês tem 31 dias");
        break;

       case 7:
       Console.Write("Esse mês tem 31 dias");
        break;

       case 8:
       Console.Write("Esse mês tem 31 dias");
        break;

       case 10:
       Console.Write("Esse mês tem 31 dias");
        break;

       case 12:
       Console.Write("Esse mês tem 31 dias");
        break;

        default:
       Console.Write("Esse mês tem 30 dias");
        break;

    }
        }
    }
}
