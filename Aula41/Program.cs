using System;
/*
Propriedade get e set
*/

class Carro{
    private int velMax;
    
    public int vm{//propriedade por isso nao tem (), caso contrario seria um metodo
        get{
            return velMax;
        }
        set{
            if(value < 0){
                velMax = 0;
            }else if (velMax > 300){
                velMax = 300;
            }else {
                velMax = value;
            }
        }
    }
    public Carro(){
        vm = 120;
    }
}
class Aula41{ 
    static void Main(string[] args){
    Carro c1 = new Carro();

    c1.vm = 200;    
    Console.WriteLine("Velocidade: {0}", c1.vm);
    }
}
