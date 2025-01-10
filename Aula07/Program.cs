using System;

    internal class Program
    {
        static void Main()
        {
            // const nao pude nunca ser alterada no programa, diferente de variavel que pode alterar o valor
            const string nome = "Quesia Silva";
            const double pi = 3.1415;

            Console.WriteLine("Nome: {0,15}\nPi: {1,11}",nome, pi);
        }
    }

