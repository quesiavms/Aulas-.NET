using System;
using System.Collections.Generic;
/*
Metodos e propriedades da coleção List
*/
class Aula58{ 
    static void Main(string[] args){
        List <string> carros = new List<string>();
        string [] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        if(carros.Contains("Gol")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("NAO Esta na lista");
        }

        carros.CopyTo(carros2,2);

        carros.Insert(1, "Cruze"); //inserindo na posicao 1 o dado Cruze

        int pos2 = carros.LastIndexOf("HRV"); //pega o utlimo endereço do HRV
 
        //carros.Remove("Argo"); //remove argo

        //carros.RemoveAt(0); //remove na posicao

        //carros.Reverse(); //reverte a ordem da lista

        carros.Sort(); //ordena os elementos

        int tamanho = carros.Count(); //quantidade de elementos na lista
        Console.WriteLine("Tamanho lista: {0}", tamanho);

        carros.Capacity = 15; 
        int capacidade = carros.Capacity; //capacidade de dados que sua lista pode armazenar
        Console.WriteLine("Capacidade lista: {0}", capacidade);

        foreach(string carro in carros){
            Console.WriteLine("Carro: {0}", carro);
        }


        string ca ="HRV";
        int pos = 0;
        pos = carros.IndexOf(ca);
        Console.WriteLine("Carro {0} esta na posicao {1}", ca, pos);
        Console.WriteLine("Ultimo HRV esta na pos {0}", pos2);


    }
}
