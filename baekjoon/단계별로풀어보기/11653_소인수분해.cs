// 1~N제곱근 범위의 소수 다 구해두기
// N을 소수 리스트 가장 작은 수부터 나누고, 나머지가 0이면 해당 소수를 출력
// 몫을 소수 리스트 가장 작은 수부터 다시 나누기
// 몫이 0이 될때까지 반복

using System;

class BJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N == 1) return; // N=1일 경우 아무것도 출력 안 함
        
        int limit = (int)Math.Sqrt(N); // 소수는 N제곱근까지만 알면 됨
        // 초기화
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++) 
        {
            isPrime[i] = true;
        }
        // 소수가 아닌 것들 false
        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
        // 소수 리스트 만들기
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i]) primes.Add(i);
        }
        
        // 소인수분해
        foreach (int p in primes)
        {
            while (N % p == 0)
            {
                Console.WriteLine(p);
                N /= p;
            }
        }

        // 마지막에 남은 수가 소수라면 출력
        if (N > 1)
        {
            Console.WriteLine(N);
        }
        
    }
}