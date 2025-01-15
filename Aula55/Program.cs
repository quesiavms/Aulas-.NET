using System;
using System.Collections.Generic;
/*
Coleção DICTIONARY -> coleção de daods onde tem um dado relacionado por uma chave e um valor
*/
class Aula55{ 
    static void Main(string[] args){
        // <tipo chave,tipo valor> podem ser iguais ou diferentes     
        Dictionary <int, string> veiculos = new Dictionary<int, string>();

        //add (chave, valor)
        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Aviao");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto"); //removemos
        veiculos.Add(15, "Patinete"); //trocando por bicicleta

        //veiculos.Clear(); //limpa o dictionary
        veiculos.Remove(20); //remover dados

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count); //count retorna int
        int chave = 20;
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("Chave {0} esta na coleção", chave);
        }else{
            Console.WriteLine("Chave {0} NAO esta na coleção", chave);
        }

        veiculos[15] = "Bicicleta"; //trocando valor da chave 15 para bicicleta

        string valor = "Bicicleta";
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("Valor {0} esta na coleção",valor);
        }else{
            Console.WriteLine("Valor {0} NAO esta na coleção",valor);
        }

        
        //percorrendo o dictionary
        Dictionary <int, string>.ValueCollection valores = veiculos.Values;
        foreach (string v in valores){
            Console.WriteLine(v);
        }        

        //percorrendo o dictionary
        // foreach (KeyValuePair<int, string> v in veiculos){
        //     Console.WriteLine(v.Value);
        //     Console.WriteLine(v.Key);
        // }

    }
}
