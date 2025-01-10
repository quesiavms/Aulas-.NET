using System;

    internal class Program
    {
        static void Main()
        {
            string nome, resposta;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Prazer {0}", nome);
            Console.WriteLine("\nDeseja usar calculadora de soma? (y/n)");
            resposta = Console.ReadLine();

            if(resposta == "y" || resposta == "Y"){
                soma();
                Console.WriteLine("\n Deseja fazer outra soma? (y/n)");
                resposta = Console.ReadLine();
                while(resposta == "y" || resposta == "Y"){
                    soma();
                    Console.WriteLine("\nDeseja fazer outra soma? (y/n)");
                    resposta = Console.ReadLine(); // Atualiza a resposta dentro do loop
                }
                Console.WriteLine("Okay, bye bye :) <3");
            }
            else{
                Console.WriteLine("Okay, bye bye :) <3");
            }        
            
        }
        static void soma(){
            
            int v1, v2, soma;

            Console.Write("\nDigite primeiro valor: ");
            v1 = int.Parse(Console.ReadLine()); //convertendo o valor para string pra o pc ler
            Console.Write("Digite segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            soma = v1 + v2;
            Console.Write("A soma de {0} e {1}, resulta em: {2} ", v1,v2,soma);
        }
    }
