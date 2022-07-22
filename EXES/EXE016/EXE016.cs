//Faça um programa que leia o comprimento do cateto oposto e do cateto 
//adjacente de um triângulo retângulo, calcule e mostre o comprimento da hipotenusa.

using System;
class EXE016 {
    static void Main(){
        Console.Write("Inform o X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("A hypotenusa é {0}", Hypotenuse(x,y));
    
    }
    static double Hypotenuse(double side1, double side2){
        return Math.Sqrt(side1*side1+side2*side2);
    }
}