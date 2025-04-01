using System;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Point p;
            p.X = 5;  // ✅ Sem erro, porque X está sendo atribuído antes de usar
            p.Y = 10;
            Console.WriteLine(p);
            Console.ReadLine(); // Mantém a janela aberta até pressionar Enter
        }
    }
}