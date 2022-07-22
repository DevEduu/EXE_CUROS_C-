using System;
class Test{
    static void Main(){
        Console.Clear();
        int[] n = new int[10];
        Random randInt = new Random();
        for(int i = 0; i <= n.Length; i++){

            n[i] = randInt.Next(0,10);
            Console.WriteLine("{0}º = {1}", i, n[i]);
        }
    }
}
