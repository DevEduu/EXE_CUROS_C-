using System;
/* Faça um programa que leia um número inteiro e mostre na tela
o seu sucessor e seu antecessor*/
class EXE04 {
    static void Main(){
        Console.Write("Informe um número: ");
        int num  = Int32.Parse(Console.ReadLine());

        Console.Write("O Sucessor de {0} e {1} e o Antecessor {2}.", num, (num++), (num--));
    }
}