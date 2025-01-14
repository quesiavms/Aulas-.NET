using System;
/*
INTERFACE: apenas implementam metodos ou o prototipo dos metodos
NAO SE USAM PROPRIEDADES NAS INTERFACE
Qualquer classe que usa uma interface, precisa implementar NECESSARIAMENTE, usar todos seus metodos
Nao tem static em interface
*/

//Primeira interface
public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

//Segunda interface
public interface Combate{
    void disparar();
}

//Classe que usa as duas interfaces, e PRECISA implementar seus metodos *OBRIGATORIAMENTE*
class Carro: Veiculo, Combate{
    public bool ligado;
    private int municao; //usuario só pode alterar com metodo {get: set}
    public Carro(){
      setMunicao(150);
    }

    public void setMunicao(int qtde){
        this.municao = qtde;
    }
    public void ligar(){
        this.ligado = true;
    }

    public void desligar(){
        this.ligado = false;
    }
    public void disparar(){
    
    }
    public void info(){
        Console.WriteLine("O carro esta ligado?\n{0}", ligado);
        Console.WriteLine("Municao Atual:\n{0}", municao);
    }

}

class Aula43{ 
    static void Main(string[] args){
    Carro c1 = new Carro();
    c1.ligar();
    c1.disparar();
    c1.info();
    }
}
