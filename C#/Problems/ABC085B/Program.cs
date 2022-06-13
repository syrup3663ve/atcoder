using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        var count = Enumerable.Range(0, n).Select(_ => int.Parse(Console.ReadLine())).Distinct().Count();
        Console.WriteLine($"{count}");
    }
}