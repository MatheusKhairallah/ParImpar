using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double numero=Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(numero%2==0)
            Console.WriteLine($"{numero} é par");
            else
            Console.WriteLine($"{numero} é ímpar");
        }
    }
}
