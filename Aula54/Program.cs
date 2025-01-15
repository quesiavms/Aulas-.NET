using System;
/*
NameSpaces e seu uso
Metodo de organização do escopo
Um grupo de elementos

Nao é possivel ter classe com o mesmo nome no mesmo namespace
Mas pode ter classes com o mesmo nome em namespaces diferentes
*/

namespace Calc1{
    class Area{
    public static float Quadrado( float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou Altura nao podem ser igual a zero");
        }
        return bas*alt;
        }   
    }
}

class Aula54{ 
    static void Main(string[] args){
        float area = 0;
        try{
            //especificar de qual namespace esta vindo a classe Area
            area = Calc1.Area.Quadrado(10f, 0f); //colocando altura como zero
            Console.WriteLine("Area do quadrado: {0}", area);
        }catch(Exception e){
            Console.WriteLine("Error: {0}", e.Message);
            Console.WriteLine("Tipo : {0}", e.GetType());
        }finally{
            Console.WriteLine("Fim do Programa");
        }
    }
}
