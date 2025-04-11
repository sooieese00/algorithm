using System;
using System.Linq;
using System.Collections.Generic;

class BOJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] weights = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(weights);
        
        long target = 1;

        foreach (int weight in weights)
        {
            if (weight>target)
            {
                break;
            }
            target += weight;
        }

        Console.WriteLine(target);

    }
}