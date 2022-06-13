using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int[] ab = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = (ab[0] * ab[1]) % 2 == 0 ? "Even" : "Odd";
        Console.WriteLine($"{result}");
    }
}
