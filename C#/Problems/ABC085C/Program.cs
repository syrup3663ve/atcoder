using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = inputs[0];
        var y = inputs[1];

        var nums1 = Enumerable.Range(0, n + 1).Where(num => num * 10000 <= y).Select(num => num * 10000).ToArray();
        var nums2 = Enumerable.Range(0, n + 1).Where(num => num * 5000 <= y).Select(num => num * 5000).ToArray();
        var nums3 = Enumerable.Range(0, n + 1).Where(num => num * 1000 <= y).Select(num => num * 1000).ToArray();

        var result = "-1 -1 -1";
        for (int i = 0; i < nums1.Length; i++) {
            for (int j = 0; j < nums2.Length; j++) {
                var k = n - i - j;
                if (k < 0 || k >= nums3.Length) continue;

                var sum = nums1[i] + nums2[j] + nums3[k];
                if (sum == y) {
                    result = $"{i} {j} {k}";
                    break;
                }
            }
        }

        Console.WriteLine(result);
    }
}