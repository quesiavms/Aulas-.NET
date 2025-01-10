using System;


public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    //metodo construtor, inicia obj quando estanciado, iniciando as propriedades da classe
    //metodo construtor pode ter parametro tambem
    // metodo construtor é iniciado automaticamente assim que se cria um objeto
    public Jogador(string n){
        //boas praticas, declarar propriedades no metodo construtor
        energia = 100;
        vivo = true;
        nome = n;
    }
    //metodo destrutor, chamdao quando garbage collector, encontra um obj nao usado e remove-o
    //aparentemente o c# tem um metodo default que ja faz isso, realizando a gestao de memoria automaticamente, por isso a mensagem não é mostrada no console
    ~Jogador(){
        Console.WriteLine("Jogador destruido");
    }
}

class Aula29{ 
    static void Main(string[] args){
        //new reserva espaço de memoria novo, cada um funciona de forma independente
        string nome1;
        Console.Write("Digite o nome do Jogador 1: ");
        nome1 = Console.ReadLine();
        
        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador("Teo");
        
        j1.energia = 80; //possivel alterar pois é publica
        Console.WriteLine("Nome jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome jogador 2: {0}", j2.nome);
        Console.WriteLine("Energia jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia jogador 2: {0}", j2.energia);

    }
}
