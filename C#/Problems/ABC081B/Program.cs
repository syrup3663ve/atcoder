using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var result = 0;
        for (var i = 2; i <= 1000000000; i *= 2) {
            if (a.Any(num => num % i != 0)) {
                break;
            }

            result++;
        }
        
        Console.WriteLine($"{result}");
    }
}