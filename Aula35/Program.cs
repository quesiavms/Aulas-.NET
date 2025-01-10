using System;

class Veiculo{ //classe base
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo (int rodas){ //construtor na clase base
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        return(ligado? "sim":"não"); // if ternario 
        //testa primeiro, se verdadeiro: se falso
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas =0;
        }
        else if(rodas > 40){
            this.rodas = 40;
        }
        else{
            this.rodas = rodas;
        }
    }
}
//classe derivada herda classe base
class Carro : Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor): base(4){
        ligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;

    }
}
//clase derivada, classe base
//CarroCombate herda carro, que herda veiculo
class CarroCombate: Carro{
    public int municao;
    public CarroCombate(): base("Carro de Combate", "Verde"){ //:base, ta usando o construtor Carro e colocando os parametros necessarios para funcionar
        municao = 100;
        setRodas(6);
    }
}
class Aula35{ 
    static void Main(string[] args){
        Carro c1  = new Carro("McQueen", "Vermelho");
        CarroCombate cc1 = new CarroCombate(); //construtor de carrocombate nao tem parametro

        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Rodas: {0}", c1.getRodas());
        Console.WriteLine("Vel.Max: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());

        Console.WriteLine("---------------------------");

        Console.WriteLine("Cor: {0}", cc1.cor);
        Console.WriteLine("Nome: {0}", cc1.nome);
        Console.WriteLine("Rodas: {0}", cc1.getRodas());
        Console.WriteLine("Vel.Max: {0}", cc1.velMax);
        Console.WriteLine("Ligado: {0}", cc1.getLigado());
        Console.WriteLine("Municao: {0}", cc1.municao);
        

    }
}
