using System;
/*
quando propriedade private, só pode ser usado dentro da classe
*/
class Jogador{
    private int energia;
    private string nome;
    public Jogador(string nome){
        this.nome = nome;
        energia = 100;
    }
    //possiblidando acesso dos private
    public int getEnergia(){
        return energia;
    }
    public string getNome(){
        return nome;
    }
    //possibilitando alteração do private
    //maximo de energia é 100, e minimo é 0
    public void setEnergia(int e){
        if(e < 0){
            if(energia + e < 0){
                energia = 0;
            }
                else{
                energia += e;
                }
        }else if (e > 0){
            if(energia - e > 100){
                energia = 100;
            }
                else{
                energia += e;
                }
        }
    }
}

class Aula33{ 
    static void Main(string[] args){
        Jogador j1 = new Jogador("Bruno");
        j1.setEnergia(-30);

        Console.WriteLine("Nome: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
}
