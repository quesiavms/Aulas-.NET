using System;

class Program{ 
    static void Main(string[] args){
    // condicao for each
    int[] num = new int[3] {11,22,33};

    /*
    for é bom para inicializar
    foreach bom para fazer leitura dos elementos de uma coleçãos
    */
    for(int i =0; i < num.Length; i++){
        Console.WriteLine(num[i]);
    }
    foreach(int n in num){
        Console.WriteLine(n);
    }

    }
}
