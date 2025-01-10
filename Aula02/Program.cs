using System;
namespace Aula02{
class Program{
    //limpar terminal -> cls
    static void Main(String[] args){
        //criar pasta obj -> dotnet new console
        Console.WriteLine("Hello World");
        if(args.GetLength(0)>0){ // confere se tem argumento ou nao
        Console.Write(args.GetValue(0)); // pega o valor passado como argumento no comando terminal -> ex. dotnet run b 
        }
    }
}
}