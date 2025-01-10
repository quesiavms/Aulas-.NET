using System;

class Aula20{
    static void Main(){

    int[] num = new int[10];

    Console.WriteLine("Looping de Incremento");
    int i =0;
    while(i < num.Length){
        num[i] = i;
        Console.WriteLine(num[i]);
        i++;
    }
    //exemplo de decremento
    Console.WriteLine("Looping de Decremento");
    int n = num.Length -1;
    while(n > 0){
        num[n] = n;
        Console.WriteLine(num[n]);
        n--;
    }    

   

}
}
