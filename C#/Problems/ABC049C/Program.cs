using System;

class Program {
    static void Main(string[] args) {
        var s = Console.ReadLine();

        s = s.Replace("eraser", "").Replace("erase", "").Replace("dreamer", "").Replace("dream", "");
        
        var result = s.Length == 0 ? "YES" : "NO";
        Console.WriteLine(result);
    }
}