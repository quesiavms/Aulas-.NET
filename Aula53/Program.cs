using System;
/*
FINALLY
Como disparar uma exceção automaticamente
*/
class Area{
    public static float Quadrado( float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou Altura nao podem ser igual a zero");
        }
        return bas*alt;
    }
}
class Aula53{ 
    static void Main(string[] args){
        int n1, n2, result;
        result= n1 = n2 = 0;
        
        n1 = 10;
        n2 = 5;

        try{
            result = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, result);
            throw new Exception("Gerando excecao"); //mesmo sem erro, a exception é mostrada
        }catch(Exception e){
            Console.WriteLine("Error: {0}", e.Message);
            Console.WriteLine("Tipo : {0}", e.GetType());
        }finally{ //executado indepente se tiver erro ou não
            Console.WriteLine("Fim do Processo");
        }

        Console.WriteLine("--------------------------");

        float area = 0;
        try{
            area = Area.Quadrado(10f, 0f); //colocando altura como zero
            Console.WriteLine("Area do quadrado: {0}", area);
        }catch(Exception e){
            Console.WriteLine("Error: {0}", e.Message);
            Console.WriteLine("Tipo : {0}", e.GetType());
        }finally{
            Console.WriteLine("Fim do Programa");
        }
    }
}
