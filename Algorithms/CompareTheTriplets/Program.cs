using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        var _aliceResult = 0;
        var _bobResult = 0;
        CompareAndAdd(a0, b0, ref _aliceResult, ref _bobResult);
        CompareAndAdd(a1, b1, ref _aliceResult, ref _bobResult);
        CompareAndAdd(a2, b2, ref _aliceResult, ref _bobResult);
        return (new List<int> { _aliceResult, _bobResult }).ToArray();
    }

    static void CompareAndAdd(int a, int b, ref int resultA, ref int resultB){
        if (a > b) 
        {
            resultA++;
        }
        else if (a < b)
        {
            resultB++;
        }
    }

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
    }
}
