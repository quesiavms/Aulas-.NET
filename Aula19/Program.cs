using System;

class Aula19{
    static void Main(){

    int[] num = new int[10];
     
     for( int n =0; n < num.Length; n++){
        num[n]= n;
        Console.WriteLine("Valor de n na posicao {0}: {1}",n ,num[n]);
     }
      
}
}

