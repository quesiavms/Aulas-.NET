using System;

class Aula11{
    static void Main(){
        //conversoes de valores
        int n1 = 10;
        float n2 = n1;

        Console.WriteLine(n2);
        
        //operação de typecast(), colocar o tipo de quer transformar entre parenteses
        float n3 = 10.5f;
        int n4 = (int)n3;
        Console.WriteLine(n3);

        //outras conversoes
        int vInt = 10;
        short vShort = (short)vInt;
        Console.WriteLine(vShort);


        
    }
    
}