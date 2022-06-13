using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int count = Console.ReadLine().ToCharArray().Count(c => c == '1');
        Console.WriteLine($"{count}");
    }
}
