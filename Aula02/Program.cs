﻿using System;

namespace Aula02 {
    class Program {
        static void Main(String[] args){
            Console.WriteLine("Olá Mundo!");
            if (args.GetLength(0)> 0){
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}