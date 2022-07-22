// Escreva um programa que converta uma 
// temperatura digitada em ºC e converta para ºF.
//(32 °C × 9/5) + 32 = 89,6 °F


using System;
class EXE013{
    static void Main(){
        Console.Write("Informe a temperatura em Cº: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double f = 32.0 + (c * (9.0/5.0));
        Console.Write("A temperatura em F° é: {0}", f);
    }
}