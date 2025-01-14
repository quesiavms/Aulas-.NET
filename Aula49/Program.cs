using System;
/*
Metodos e Variaveis Static de uma classe nao static
*/

class Mat{
    public static double pi = 3.14;
    public static int dobro(int n){
        return n * 2;
    }
}
class Aula49{ 
    static void Main(string[] args){
        //nao é necessaria criar um obj da clase Mat
        //podemos acessar as propriedades e metodos pois sao static
        double valorPi = Mat.pi;
        int num = 10;

        Console.WriteLine(valorPi);
        Console.WriteLine(Mat.dobro(num));
    }
}
