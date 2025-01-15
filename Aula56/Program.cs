using System;
using System.Collections.Generic;
/*
LinkedList, lista duplamente cadeada
*/
class Aula56{ 
    static void Main(string[] args){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta"); //veio adicionando tudo por primeiro

        transp.AddLast("Bicicleta"); //adicionado por ultimo

        LinkedListNode<string> no; //criando uma lista para o nó
        no = transp.FindLast("Carro"); //localizando o ultimo valor Carro
        transp.AddAfter(no, "Patinete"); // adicionando depois de Carro, a variavel Patinete
        transp.AddBefore(no, "Patins"); //adicionando antes de Carro, a variavel Patins

        //transp.Clear(); apagar tudo
        //retorna referencia do carro
        if(transp.Find("Carro") == null){
            Console.WriteLine("Nao encontrado !!");
        }else{
            Console.WriteLine("Elementro encontrado!!");
        }

        //remover elemento
        //transp.Remove("Navio");

        //remover primeiro elemento
        //transp.RemoveFirst();
        //remover ultimo elemento
        //transp.RemoveLast();

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}
