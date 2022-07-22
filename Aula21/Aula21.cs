using System;
class Aula21{
    static void Main(){
        string senha = "123";
        string senhaadm;

        do
        {
            Console.Write("Digite a senha: ");
        senhaadm = Console.ReadLine();
            Console.Clear();
        } while (senha != senhaadm);
        Console.Write("Programa finalizado!");
    }
}