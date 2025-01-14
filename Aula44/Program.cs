using System;
/*
STRUCT -> tipo de estrutura para armazenar diferentes tipos de dados
struct não é classe
*/
struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("-----------------------");
        Console.WriteLine("Marca...: {0}", this.marca);
        Console.WriteLine("Modelo..: {0}", this.modelo);
        Console.WriteLine("Cor.....: {0}", this.cor);
    }
}

class Aula44{ 
    static void Main(string[] args){
        //ja esta usando a a struct, nao precisa estanciar
        Carro c1;
        c1.cor = "Azul";
        c1.marca = "VW";
        c1.modelo = "Golf";

        //chamando pelo construtor, e temos parametros no construtor
        Carro c2 = new Carro("Honda", "Civic G10", "Branco");

        c1.info();
        c2.info();
    }
}
