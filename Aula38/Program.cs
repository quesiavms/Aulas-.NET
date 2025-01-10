using System;
/*
Metodos Virtuais, podem ser sobreescritos
quando acessado pelo objeto é retornado o da derivada, ou seja o override
Tendo que o virtual, foi sobreescrito pelo override
*/
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void Info(){
        //boas praticas é só definir no override e nao aqui oq seja retornado
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada 1");
    }
    override public void Info(){
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada 2");
    }
    override public void Info(){
        Console.WriteLine("Derivada 2");
    }

}
class Aula38{ 
    static void Main(string[] args){
        //elemento de referencia que pode receber as classe derivadas da base
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        //voce pode usar o Ref pra acessar objeto de qualquer derivada 
        Ref = derivada2;
        Ref.Info();


    }
}
