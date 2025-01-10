﻿using System;

class Program{ 
    static void Main(string[] args){
        /*
        argumento out
        semelhante ao argumento ref
        porem permite que vc tenha possibilidade do metodo retornar mais de um valor
        */
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 3;
        quoc = divide(divid, divis, out rest);
        Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", divid, divis, quoc, rest);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }
}


