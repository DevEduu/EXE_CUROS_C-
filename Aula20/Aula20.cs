using System;
using System.Threading;
class Aula20 {
    static void Main(){
        var name = "Eduardo Soares de Oliveira";
        int num = 0;
        Console.Clear();
        while(num <= 3 ){
            Console.WriteLine("\nSejá bem vindo ");
            
            for(int i = 0; i<=(name.Length - 1); i++){
                Console.Write("{0}",name[i]);
                Thread.Sleep(240);
            }
            num++;
        }
    }
}