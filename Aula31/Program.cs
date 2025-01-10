using System;
/*
Classe static tem propriedade static (obrigatoriamente)
Quando classe static nao precisa ser estanciada, pois ja esta ocupando um espaço na memoria
*/

static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;

static public void iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }


static public void info(){
    Console.WriteLine("Nome jogador: {0}", nome);
    Console.WriteLine("Energia jogador: {0}", energia);
    Console.WriteLine("Status jogador: {0}\n", vivo);
}
}

class Inimigo{
    static public bool alerta;
    public string nome;
    //metodo construtor
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    //metodo
    public void info(){
        Console.WriteLine("Nome do inimigo: {0}", nome);
        Console.WriteLine("Estado de alerta: {0}\n", alerta);
    }
}

class Aula31{ 
    static void Main(string[] args){
        //por ser static acessamos apenas a classe, pois nao é permitido ser estanciad, toda e qualquer alteração, vai alterar tododo o sistema 
        Jogador.iniciar("Bruno");
        Jogador.info();

        Inimigo inimigo1 = new Inimigo("Baltazard");
        Inimigo inimigo2 = new Inimigo("Voldemort");
        Inimigo inimigo3 = new Inimigo("Barata");

        //acessando pela classe pois é static e altera para todos os obejtos
        Inimigo.alerta = true;

        inimigo1.info();
        inimigo2.info();
        inimigo3.info();    
    }
}
