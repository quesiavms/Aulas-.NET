using System;
/*
DELEGATES -> obj que pode fazer referencia a varios metodos dentro da classe
Ele contem o endereço de memoria do ponto de entrada do metodo
*/
delegate int Op(int n1, int n2);

class Mat{
    // public static int soma(params int[] n){
    //     int soma = 0;
    //     for (int i =0; i < n.Length; i++){
    //         soma += n[i];
    //     }
    //     return soma;
    // }
    public static int mult(int n1, int n2){
        return n1 * n2;
    }
    public static int soma(int n1, int n2){
        return n1 + n2;
    }

}
class Aula50{ 
    static void Main(string[] args){
    
    int resultado;
    
    //usando delegate que pode usar varios metodos
    Op d1 = new Op(Mat.mult);
    resultado = d1(10,50);
    Console.WriteLine("Multiplicacao: {0}", resultado);

    d1 = new Op(Mat.soma);
    resultado = d1(10,50);
    Console.WriteLine("Soma: {0}", resultado);
    
    }
}
