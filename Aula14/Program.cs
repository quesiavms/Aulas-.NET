﻿using System;

class Aula14{
    static void Main(){
        // learning if condition
        int n1, n2, n3, n4, res;
        n1=n2=n3=n4=res=0;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());
        
        res = n1+n2+n3+n4;

        //if alinhado :)
        if(res > 60){
            if(res >= 90){
                if(res >= 99){
                    resultado = "Aprovadisiimoo!!";
                }else{
                resultado = "Aprovado com Louvor !!!";
            }
            }
            else{
                resultado = "Aprovado";
            }
        }
        else{
             if(res >= 40){
                resultado = "Recuperação";
             }else{
                resultado = "Reprovado";
             }
        }
        Console.WriteLine("Nota: {0}\nResultado: {1}", res,resultado);
    }
}
