using System;

class BOJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // 자연수 1~116까지 주어지기 때문에 new long[115]로 선언해주어야 
        // 인덱스 0~115까지 만들어짐
        long[] fibo = new long[115];
        fibo[0] = fibo[1] = fibo[2] = 1;

        for(int i = 3; i<N; i++)
        {
            fibo[i] = fibo[i-1]+fibo[i-3];
        }

        Console.WriteLine(fibo[N-1]);
    }
}