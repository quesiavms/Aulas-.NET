using System;
/*
Metodos que retornam objetos 
*/

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    //tipo public, retorna Ovo, nomeMetodo ()
    public Ovo botar(){
        numOvo ++;
        return new Ovo(numOvo, nomeGalinha);
    }
    public void totalOvosPorGalinha() {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("{0} botou um total de {1} ovos.", nomeGalinha, numOvo);
    }
}
class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", numOvo, minhaGalinha);
    }

}
class Aula46{ 
    static void Main(string[] args){
        Galinha g1 = new Galinha("Benedita");
        Galinha g2 = new Galinha("Felizarda");
        Galinha g3 = new Galinha("Gestrudes");
        //galinha 1, 3 ovos;
        g1.botar();
        g1.botar();
        g1.botar();

        //galinha 2, 1 ovo;
        g2.botar();

        //galinha 3, 2 ovos;
        g3.botar();
        g3.botar();

        g1.totalOvosPorGalinha();
        g2.totalOvosPorGalinha();
        g3.totalOvosPorGalinha();
    }
}
