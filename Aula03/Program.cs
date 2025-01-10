using System;
namespace Aula03{
class Program{
    //limpar terminal -> cls
    static void Main(String[] args){
        byte n1 = 10; // entra 0 e 255
        int num = 0;
        char letra = 'c'; // pode ser numero tambem
        float valor = 5.3f;
        string nome = "Quesia";
        var aux = nome; //var nao especifica tipo de variavel, mas é especificada tipo de acordo com contribuição

        Console.WriteLine("Nome: " + aux);

        int num1, num2, res;
        num1 = 10;
        num2 = 2;
        res = num1*num2;

        Console.WriteLine("A multiplicação de "+num1+ " e " + num2 + " é: "+ res );
    }
}
}