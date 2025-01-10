using System;
/*
Classe selada => ela nao pode ser herdada, classe normal :)
*/

sealed class Veiculo{

}

class Carro:Veiculo{ //nao pode derivadas nao parceiro

}
class Aula40{ 
    static void Main(string[] args){
        Carro c1 = new Carro();
    }
}
