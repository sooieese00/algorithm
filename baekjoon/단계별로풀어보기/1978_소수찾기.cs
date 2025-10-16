// 소수: 루트를 씌운 이후에 1부터 루트값까지만 검사, 1은 제외

using System;
class BJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int cnt = 0;
        
        for(int i = 0; i<N; i++)
        {
            int k =  numbers[i];
            bool isPrime = true;
            for(int j = 2 ; j<=Math.Sqrt(k); j++ )
            {
                if( k%j==0)
                {
                    isPrime = false;
                }
            }
            if(k!=1 && isPrime)
            {
                cnt++;
            }
        }
        
        Console.WriteLine(cnt);
        
    }
}