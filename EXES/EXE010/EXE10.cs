/*Faça um programa que leia a largura e a altura de uma 
parede em metros, calcule a sua área e a quantidade de 
tinta necessária para pintá-lo,sabendo que cada litro 
de tinta, pinta uma área de 2m².*/
using System;

class EXE10{
    static void Main(){
        Console.Write("Informe a a altura: ");
        var alt = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe largura: ");
        var lar = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("O área a ser pintada será de {0} m²", alt*lar);

    }
}
