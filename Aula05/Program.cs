using System;

class Program{
    static void Main(string [] args){
        int result = (10+5) * 2;
        Console.WriteLine(result);

        bool res = 10!=5;
        //num++, num+=1, num = num+1
        //num+=2, num = num+2
        Console.WriteLine(res);
        // & = AND 
        // | = OR

        bool resp = (5>3) | (10<5);
        Console.WriteLine(resp);
    }
}