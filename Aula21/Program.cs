using System;

class Aula21{
    static void Main(){
        string senha = "123";
        string senhaUser;
        int tentativas = 0;

        do{
            Console.Clear();
            Console.WriteLine("Digite Senha: ");
            senhaUser = Console.ReadLine();
            tentativas ++;
        }
        while(senha != senhaUser);

        Console.WriteLine("Senha correta, tentativas {0}", tentativas);
        conferirSenha3Tentativas();    
    }
    static void conferirSenha3Tentativas(){
    string senha = "123";
    string senhaUser;
    int tentativas = 0; // Contador de tentativas
    int maxTentativas = 3; // Número máximo de tentativas

    do{
        Console.WriteLine("Digite a senha: ");
        senhaUser = Console.ReadLine();
        tentativas++;

        if (senha == senhaUser){
            Console.WriteLine("Senha correta", tentativas);
            return; // Sai do método
                               }
        else{
            Console.WriteLine("Senha incorreta. Você tem {0} tentativas restantes.", maxTentativas - tentativas);
            }
        } 
    while(tentativas < maxTentativas);

    Console.WriteLine("Número máximo de tentativas atingido. Acesso bloqueado.");
}
}

