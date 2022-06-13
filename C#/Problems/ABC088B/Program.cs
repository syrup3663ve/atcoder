using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(a => a).ToArray();

        var result = nums.Where((num, index) => index % 2 == 0).Sum() - nums.Where((num, index) => index % 2 == 1).Sum();
        Console.WriteLine($"{result}");
    }
}