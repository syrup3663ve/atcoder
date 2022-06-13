using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = input[0];
        var a = input[1];
        var b = input[2];

        var result = Enumerable.Range(1, n).Where(num => {
            var sum = num.ToString().Select(s => int.Parse(s.ToString())).Sum();
            return a <= sum && sum <= b;
        }).Sum();
        
        Console.WriteLine($"{result}");
    }
}