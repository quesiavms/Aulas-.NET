using System;
/*
Array de Estruturas, la no nosso metodo main
*/

struct Carro{
    public string modelo;
    public string cor;

    public void info(){
        Console.WriteLine("-----------------------");
        Console.WriteLine("Modelo..: {0}", this.modelo);
        Console.WriteLine("Cor.....: {0}", this.cor);
    }
}

class Aula45{ 
    static void Main(string[] args){
    //Criando normalmente como um array
    int[] numeros = new int[10];

    Carro[] carros = new Carro[4];

    carros[0].modelo ="HRV";
    carros[0].cor ="Prata";

    carros[1].modelo ="Golf";
    carros[1].cor ="Cinza";
    
    carros[2].modelo ="Jetta";
    carros[2].cor ="Preto";
    
    carros[3].modelo ="Civic";
    carros[3].cor ="Branco";

    for(int i = 0; i < carros.Length; i++){
        carros[i].info();
        }

    //tentando outro tipo de looping
    foreach (Carro carro in carros){
        carro.info();
        }
    }
}

