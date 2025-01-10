using System;

class Aula16{
    static void Main(){
    //switch case
    int tempo = 0;
    char escolha;
    
    //criando label para usar go to
    inicio: 
    Console.Clear(); // limpar a telinha :)

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

        Console.WriteLine("\nDeseja calcular tempo com outro transporte? (y/n)");
        escolha = char.Parse(Console.ReadLine());
        if(escolha == 'y' || escolha == 'Y'){
            //looping pra usar o label inicio que criamos no começo do codigo
            goto inicio;
        }
        else{
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }

    }
}

