using System;

class Aula10{
    // enumeradores, conjunto de constantes :)
    enum diasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado}
    static void Main(){
       //usando o enumerador normal 
        diasSemana ds = diasSemana.Domingo;
        Console.WriteLine(ds);

       //usando por indice
        diasSemana ds1 = (diasSemana)3; //convertendo o numero para enumerador de dias da semana
        Console.WriteLine(ds1);

       //usando o int do enumerador 
        int ds2 = (int)diasSemana.Sexta;
        Console.WriteLine(ds2);

    }
}
