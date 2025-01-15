using System;
using System.Collections.Generic;
/*
Coleção Queue -> Fila (primeiro a entrar, primeiro a sair) -> First In First Out
Não é possivel usar index
Apenas manipular e alterar o primeiro elemento da fila
*/
class Aula59{ 
    static void Main(string[] args){

        //string[] vs = {"Carro", "Moto", "Navio", "Aviao"};
        Queue <string> veiculos = new Queue<string>(); //caso queria inicar com uma coleção só colocar vs no argumento

        veiculos.Enqueue("Carro"); //adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");
        
        string v = "Patinete";
        if(veiculos.Contains(v)){ //contem, true ou false
            Console.WriteLine("Veiculo " + v + " ecncontrado");
        }else{
            Console.WriteLine("Veiculo "+ v + " nao esta na fila");
        }
        Console.WriteLine("----------------------------------------");

        //veiculos.Clear(); //limpa a fila

        Console.WriteLine("Tamanho original da fila: {0}", veiculos.Count); //conta
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primeiro Veiculo: {0} -> não removido", veiculos.Peek()); //apenas retorna primeiro elemento, nao exclui
        Console.WriteLine("Tamanho fila: {0}", veiculos.Count); //conta
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primeiro Veiculo: {0} -> removido", veiculos.Dequeue()); //pega primeiro elemento e remove (dequeue) ele, first in first out
        Console.WriteLine("Tamanho fila: {0}", veiculos.Count); //conta
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primeiro Veiculo: {0} -> removido", veiculos.Dequeue()); //pega primeiro elemento e remove (dequeue) ele, first in first out
        Console.WriteLine("Tamanho fila: {0}", veiculos.Count); //conta
        Console.WriteLine("----------------------------------------");
        
        foreach(string veic in veiculos){
            Console.WriteLine("Veiculo {0}", veic);
        }

        Console.WriteLine("Tamanho fila: {0}", veiculos.Count); //conta
        Console.WriteLine("----------------------------------------");

        while(veiculos.Count > 0){
            Console.WriteLine("Vaiculo removido " + veiculos.Dequeue());
        }
        
        Console.WriteLine("Tamanho fila: {0}", veiculos.Count); //conta
        Console.WriteLine("----------------------------------------");
        
    }
}
