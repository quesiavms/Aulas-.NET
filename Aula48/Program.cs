using System;
/*
RECURSIVIDADE -> funcao chamando ela mesma
*/
class Calc{
    // 5! = 5*4*3*2*1
    public int fatorial(int n){
        int res;
        if( n <= 1){
            res = 1;
        }else{
            res = n * fatorial(n - 1);
        }
        return res;
    }
}
class Aula48{ 
    static void Main(string[] args){
        Calc calculadora = new Calc();

        var res = calculadora.fatorial(5);
        Console.WriteLine(res);

    }
}
