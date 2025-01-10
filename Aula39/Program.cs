using System;
/*
Classe Abstratas: podem ter metodos abstratos e nao abstratos
Metodos Abstratos: nao implementa conteudo, apenas o prototipo 
Se um classe deriva de uma classe abstrata, esta por sua vez, tem que obrigatoriamente implementar todos os metodos abstratos 
*/

abstract class Veiculo{//classe base abstrata
    /*
    Nao se instancia objetos de classe abstrata, elas apenas sao herdadas
    */
    protected int VelMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult); //obrigatorio a implementar esse metodo, pois é abstrato
}

class Carro:Veiculo{
    public Carro(){
        VelMax = 120;
    }
    override public void aceleracao(int mult){//obrigatorio a implementar esse metodo, pois é abstrato
        velAtual+=10*mult;
    }
}

class Aula39{ 
    static void Main(string[] args){
        Carro carro1 = new Carro();

        carro1.aceleracao(1); //aumentando a aceleração, mudando a velocidade atual
        Console.WriteLine(carro1.getVelAtual());
    }
}
