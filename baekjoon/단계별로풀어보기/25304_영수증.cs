// 두 번째 줄 N개만큼 for문으로 readline
// 각 줄에 첫번째*두번째
// 다 더하기

using System;

class BJ
{
    static void Main()
    {
        int total = Convert.ToInt32(Console.ReadLine());
        int num = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        
        for(int i = 0; i<num; i++)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            (int a, int b) = (nums[0], nums[1]);
            sum += a*b;
        }
        
        Console.WriteLine(sum==total? "Yes":"No");
        
    }
}