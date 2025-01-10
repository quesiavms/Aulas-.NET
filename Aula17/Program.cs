using System;

class Aula17{
    static void Main(){
        //criando array, vulgo vetores
        // tipo valor nome = inicialização
        int[] n = new int [5];
        // adicionando valores no array
        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;
        Console.WriteLine(n[0]);
        
        //declarando array, colocando o tamanho array, e atribuindo elementos ao array
        int [] num = new int[3]{1,2,3};
        Console.WriteLine(num[1]);

        //criando array e ja atribuindo elementos, tamanho do array é o numero de elementos atribuidos
        int [] n1 = {4,5,6};
        Console.WriteLine(n1[1]);
        
        
 
    }
}
