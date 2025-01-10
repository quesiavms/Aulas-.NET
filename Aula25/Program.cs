using System;

class Program{ 
    static void Main(string[] args){
        int num = 10;
        
        dobrar2(num);
        Console.WriteLine(num);
        /*passagem por referencia, para alterar de fato o num
        sem o ref, o num nao é atualizado e se mantem como 10
        sem o ref, estamos passando valor, e assim nao é atualizado
        quando usamos ref estamos pedindo pra atualizar o valor da variavel
        */
        dobrar1(ref num);
        Console.WriteLine(num);
    }

    static void dobrar1(ref int valor){
        valor*=2;
    }
    static void dobrar2(int valor){
        valor*=2;
    }
}

        
