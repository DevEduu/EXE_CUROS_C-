using System;

class Aula09{
    static void Main(){
        int num1 = 8;
        int num2 = 10;

        num1 = num1<<2;// Dobra o valor a cada ciclo determinando <<2
        num2 = num2>>1; //Diminur pela mentada a cada ciclo determinado >>1


        Console.WriteLine("Num1 = {0}, Num2 = {1}", num1,num2);
    }
}