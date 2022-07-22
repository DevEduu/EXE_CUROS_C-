using System;
// Escreva um programa que leia um valor 
// em metros e o exiba convertido em centimetros e milimetros.
class EXE07 {
    static void Main(){
        Console.Write("\nInfome um valor em metros: \n");
        double metros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Em centrimetro....: {0} cm ", (metros*100));
        Console.WriteLine("Em Milimetros.....: {0} mm \n", (metros*1000));

    }
}