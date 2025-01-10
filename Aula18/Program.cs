using System;

class Aula18{
    static void Main(){
       //criando matriz
       // tipo valor nome = inicialização
        int[,] n = new int [3,5]; // 3 linhas, 5 colunas
       //linha 1
        n[0,0] = 10; n[0,1] = 20; n[0,2] = 30; n[0,3] = 40; n[0,4] = 50; 
       //linha 2
        n[1,0] = 60; n[1,1] = 70; n[1,2] = 80; n[1,3] = 90; n[1,4] = 15;
       //linha 3
        n[2,0] = 25; n[2,1] = 35; n[2,2] = 45; n[2,3] = 55; n[2,4] = 65;
        
        Console.WriteLine(n[2,1]);
        
        //declarando e atribuindo direto
        int[,] num = new int [2,2]{{10,20}, {30,40}};
        
        Console.WriteLine(num[1,1]);
        
      
    }
}
