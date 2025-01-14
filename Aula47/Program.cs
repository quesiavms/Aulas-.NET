using System;
/*
Sobrecarga de Metodos, metodos com o mesmo nome, na mesma classe
no nosso caso, eles tem parametros diferentes, um é int, outro é double
Em ambos os casos o parametro é um vetor, para que o usuario possa add quantos numeros quiser a sua soma
*/

class Calc{
    //params permite vc adicionar quantos vc quiser
    public int soma(params int[] n){
        int soma = 0;
        for(int i=0; i < n.Length; i++){
            soma+=n[i];
        }
        return soma;
    }
    public double soma(params double[] n){
        double soma = 0.0;
        for(int i=0; i < n.Length; i++){
            soma=+n[i];
        }
        return soma;
    }
}
class Aula47{ 
    static void Main(string[] args){
        Calc calculadora = new Calc();

        /*
        Possivel adicionar quantos argumentos quiser
        Podendo ser inteiros ou doubles, pois é uma sobrecarga, ou seja metodos com mesmo nome
        */
        var res = calculadora.soma(5.2,20.3, 30.4, 40.5,60.6);
        Console.WriteLine(res);

    }
}
