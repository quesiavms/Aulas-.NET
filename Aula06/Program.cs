using System;

class Aula06{
    static void Main(){
        int n1, n2,n3;
        n1 = 10; n2 =20; n3= 30;
        //se referindo a posição das variaveis por indice
        Console.Write("n1 = {0}, n2 = {1}, n3 = {2}",n1,n2,n3);
        Console.Write("\nn1 = {0}, \nn2 = {1},\nn3 = {2}\n",n1,n2,n3);
        exemplo1(1);
    }

    static void exemplo1(int n){
        Console.WriteLine("exemplo {0}", n);
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);
        /*indice com espaçamento
        {0,15:c}, 0 é o indice, 15 é o espaçamento, :c é para colocar no formato de dinheiro,moeda 
        {0,15:p}  0 é o indice, 15 é o espaçamento, :p é o valor em porcentagem
        */
        Console.WriteLine("Produto...........{0,15}", produto);
        Console.WriteLine("Val.Compra........{0,15:c}", valorCompra);
        Console.WriteLine("Lucro.............{0,15:p}", lucro);
        Console.WriteLine("Val.Venda.........{0,15:c}", valorVenda);
        }
}
