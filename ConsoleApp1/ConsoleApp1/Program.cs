using System;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            sbyte a = 127;
            int n2 = 1;
            int n3 = 256465489;
            long n4 = 465465465465465465L;

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            float n5 = 4.5f;
            double n6 = 4.5;

            string nome = "Maria Luiza";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
        }
    }
}