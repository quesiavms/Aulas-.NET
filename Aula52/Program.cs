using System;
/*
Tratamento de exceções (possiveis erros)
*/
class Aula52{ 
    static void Main(string[] args){
        int n1, n2, result;
        result= n1 = n2 = 0; //iniciando tudo junto :) 
        
        n1 = 10;
        n2 = 0;
        /*
        Apenas vai executar o try inteiro se nao encontrar nenhum erro para ser tratado
        */
        try{
            result = n1/n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, result);
        }catch(Exception e){
            Console.WriteLine("Error: {0}", e.Message); //erro tratado
            Console.WriteLine("TIpo : {0}", e.GetType()); //erro tratado
        }

    }
}
