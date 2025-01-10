using System;

class Program{ 
    static void Main(string[] args){
        /*
        uso do params
        metodo que pode receber 0, ou mais de um parametro
        o metodo funcionara em todos os casos
        */
        Console.WriteLine("Com nenhum parametro: ");
        soma();
        Console.WriteLine("Com um unico parametro: ");
        soma(10);
        Console.WriteLine("Com dois parametros: ");
        soma(10,5);
        Console.WriteLine("Com mais de dois parametros: ");
        soma(10,5,2,4,7);
    }

    static void soma(params int[]n){
        int res = 0;
        /*
        fazendo a condição que trata todos os casos de parametros recebidos
        1 - recebendo nenhum paramento ( < 1)
        2 - recebendo só um parametro ( < 2)
        3 - recebendo 2 ou mais parametros (else)
        */
        if(n.Length < 1){
            Console.WriteLine("Nao existem valores a serem somados");
        }else if (n.Length < 2){
            Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
        }else{
            for(int i = 0; i < n.Length; i++){
                res+=n[i];
           }
           Console.WriteLine("A soma dos valores é {0}",res);
    
        }
        
    }
}
