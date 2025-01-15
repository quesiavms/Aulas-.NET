using System;
using System.Collections.Generic;
/*
Coleção LIST -> array dinamico 
*/
class Aula57{ 
    static void Main(string[] args){
        List <string> carros = new List<string>();
        string [] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros); //add oq ta em carros em carros2

        //carros.Clear();

        if(carros.Contains("Gol")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("NAO Esta na lista");
        }

        carros.CopyTo(carros2,2);

        foreach(string carro in carros){
            Console.WriteLine("Carro: {0}", carro);
        }

    string ca ="HRV";
    int pos = 0;
    pos = carros.IndexOf(ca);
    Console.WriteLine("Carro {0} esta na posicao {1}", ca, pos);


    }
}
