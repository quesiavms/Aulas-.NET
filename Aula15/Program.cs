﻿using System;

class Aula15{
    static void Main(){
    //switch case
    int tempo = 0;
    char escolha;
    Console.WriteLine("Viagem de Belo Horizonte/MG para Vitoria/ES");
    Console.WriteLine("Escolha o transporte: [a] Aviao, [c] Carro, [o] Onibus");
    escolha = char.Parse(Console.ReadLine());

    switch(escolha){
        case 'a':
        case 'A': 
            tempo = 50;
            break;
        case 'c':
        case 'C':
            tempo = 480;
            break;
        case 'o':
        case 'O':
            tempo = 660;
            break;
        default: 
            tempo = -1;
            break;
    }
        if( tempo < 0){
            Console.WriteLine("Transporte Indisponivel");
        }
        else{
            Console.WriteLine("Tempo para o transporte escolhido é: {0} minutos", tempo);
        }
    }
}

