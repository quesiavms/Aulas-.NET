using System;
/*
LETS TALK ABOUT CLASSES HAHAHAHH
classe jogador, propriedades: energia e vivo
*/

public class Jogador{
    public int energia = 100;
    public bool vivo = true;
}

class Aula28{ 
    static void Main(string[] args){
        //new reserva espaço de memoria novo, cada um funciona de forma independente
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 80; //possivel alterar pois é publica
        Console.WriteLine("Energia jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia jogador 1: {0}", j2.energia);

    }
}
