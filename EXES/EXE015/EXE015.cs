/*Crie um programa que leia um número Real qualquer pelo teclado e 
mostre na tela a sua porção inteira. EX:Digite um número:6.127. 
O número 6.127 tem a parte interia 6.*/
using System;
class EXE015{
    static void Main(){
        Console.Write("Digite um número real: ");
        var num = Convert.ToDecimal(Console.ReadLine());
        int numInt = num;
        Console.Write("O número {0} tem a parte interia {1}.",num, numInt);
    }
}