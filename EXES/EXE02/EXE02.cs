using System;
// Faça um programa que leia o nome 
// de uma pessoa e mostre uma mensagem de boas-vindas.
class EXE02{
    static void Main(){
        Console.Write("Informe o seu nome: ");
        
        String nome =  Console.ReadLine();

        Console.Write("Seja bem vindo {0}.",nome);
    }
}