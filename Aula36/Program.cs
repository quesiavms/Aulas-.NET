using System;

/*
Private => acessa apenas na propria classe, demais acessos precisa de get e set
Protected => pode acessar na propria classe e classe derivada, para instanciação precisa de get e set
*/

class Veiculo{//Base
    public int velAtual;
    private int velMax; //acessa pela propria classe
    protected bool ligado; // acessa pela classe e classes derivadas

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }

}

class Carro:Veiculo{//derivada de Veiculo
    public string nome;

/*
Veiculo tem parametro int velMax, por isso foi usado :base(vm)
Estamos passando como argumento, o mesmo parametro colocado no construtor de Carro(string nome, int vm);
*/
    public Carro(string nome, int vm):base(vm){
        this.nome = nome;
        ligado = true; //da pra acessar na classe derivada, mas nao no objeto
    }
}
class Program{ 
    static void Main(string[] args){
        Carro carro = new Carro("McQueen", 120);

        Console.WriteLine("Nome: {0}\nVelMax: {1}\nLigado: {2}", carro.nome, carro.getVelMax(), carro.getLigado());
    }
}
