using System;

class Aula09{
    static void Main(){
        /*operador bitwise dentro de variaveis inteiras e suas interações
        << dobra o valor
        >> metade do valor
        */
        int num1, num2;
        num1 = 2;
        num2 = 40;

        num1 = num1 << 2; // ta dobrando o valor duas vezes
        num2 = num2 >> 2; // metade duas vezes
        Console.WriteLine("Numero 1: {0}\nNumero 2: {1}", num1, num2);
    }
}
