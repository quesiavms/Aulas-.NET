using System;

class Program{ 
// metodos em C#
    static void Main(string[] args){
    /*    
      for(int i =0; i < 2; i++){
        metodo1();
      }
    */
      int v1, v2,result;
      Console.Write("Digite valor 1: ");
      v1 = int.Parse(Console.ReadLine());
      Console.Write("Digite valor 2: ");
      v2 = int.Parse(Console.ReadLine());
      result = soma(v1,v2); //result ta recebendo o retorno de soma
      Console.WriteLine("Soma de {0} e {1} é {2}", v1, v2, result);
    }

    /*
    static void metodo1(){
        Console.WriteLine("Olaa");
    }
    */
    static int soma(int n1, int n2){
        int soma = n1 + n2;
        return soma;
    }

}
