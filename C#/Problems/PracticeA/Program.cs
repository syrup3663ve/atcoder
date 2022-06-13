using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int a = int.Parse(Console.ReadLine());
        int[] bc = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
        string s = Console.ReadLine();
        Console.WriteLine($"{a + bc[0] + bc[1]} {s}");
    }
}