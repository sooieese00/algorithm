using System;
using System.Linq;
using System.Collections.Generic;

class BJ
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        
        // 에라토스테네스의 체
        bool[] isPrime = new bool [N+1];
        for(int i = 2; i<N+1 ; i++)
        {
            isPrime[i] = true;
        }
        
        for(int i = 2; i<Math.Sqrt(N); i++)
        {
            if(isPrime[i])
            {
                for(int j = i*i ; j<N+1; j+=i )
                {
                    isPrime[j] = false;
                }
            }
        }
        
        List<int> primes = new List<int>();
        for(int i = M; i<=N ; i++)
        {
            if(isPrime[i])
            {
                primes.Add(i);
            }
        }
        
        if(primes.Count==0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(primes.Sum());
            Console.WriteLine(primes.Min());
        }
        
        
    }
}