using System;

class Veiculo{ //classe base
    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        if(ligado){
            return "sim";
        }else {
            return "não";
        };
    }
}
//classe derivada herda classe base
class Carro : Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;

    }
}
class Aula34{ 
    static void Main(string[] args){
        Carro c1  = new Carro("McQueen", "Vermelho");
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Rodas: {0}", c1.rodas);
        Console.WriteLine("Vel.Max: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());

    }
}
