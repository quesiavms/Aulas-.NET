using System;

class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2){
        //this faz referencia ao objeto
        this.v1 = v1;
        this.v2 = v2;
    }
    public int Soma(){
        return v1 + v2;
    }
}
class Aula32{ 
    static void Main(string[] args){
        Calculos c = new Calculos(3,10);
        Console.Write(c.Soma());
    }
}
