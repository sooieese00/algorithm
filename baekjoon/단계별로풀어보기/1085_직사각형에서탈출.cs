using System;
using System.Linq;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        (int x, int y, int w, int h) = (line[0], line[1], line[2], line[3]);

        int[] nums = new int[4];
        nums[0] = x;
        nums[1] = y;
        nums[2] = w-x;
        nums[3] = h-y;
        
        Console.WriteLine(nums.Min());
        
    }
}