using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var aInput = int.Parse(Console.ReadLine());
        var bInput = int.Parse(Console.ReadLine());
        var cInput = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());

        var aList = Enumerable.Range(0, aInput + 1).Select(n => n * 500).ToList();
        var bList= Enumerable.Range(0, bInput + 1).Select(n => n * 100).ToList();
        var cList= Enumerable.Range(0, cInput + 1).Select(n => n * 50).ToList();

        var count = 0;
        aList.ForEach(a => {
            bList.ForEach(b => {
                count += cList.Count(c => a + b + c == x);
            });
        });
        
        Console.WriteLine($"{count}");
    }
}