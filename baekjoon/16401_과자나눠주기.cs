using System;

class BOJ
{
    static void Main()
    {
        string[] strings = Console.ReadLine().Split();
        int M = int.Parse(strings[0]);
        int N = int.Parse(strings[1]);

        int[] snacks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int shortest = 1;
        int longest = snacks.Max();

        int result = 0;

        while (shortest<=longest)
        {
            int mid = (shortest+longest)/2;
            int count = 0;

            foreach(int snack in snacks)
            {
                count += snack/mid;
            }
            if(count>=M)
            {
                // 일단 결과로 저장해두기
                result = mid; 
                shortest = mid+1;
            }
            else
            {
                longest = mid-1;    
            }
        }

        Console.WriteLine(result);

    }
}