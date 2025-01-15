using System;
/*
Argumentos de entrada para o programa
(strings [] args)
vamos usar isso no console
*/
class Aula51{ 
    static void Main(string[] args){

        int result = 0;

        if(args.Length > 0){
            Console.WriteLine("Qtd de argumentos: {0}", args.Length);
            foreach (string arg in args){
                Console.WriteLine("Argumento passado: {0}", arg);
                result += Int32.Parse(arg);
            }
            Console.WriteLine("Soma: {0}", result); //fazaendo conta com os argumentos passados
            //outro tipo de looping
            // for(int i = 0; i < args.Length; i++){
            //     Console.WriteLine("Argumento {0}: {1}", i, args[i]);
            // }
        }else{
            Console.WriteLine("Nao foram passados argumentos");
        }
    }
}
