using System;

class BOJ
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int N = int.Parse(inputs[0]);
        int M = int.Parse(inputs[1]);

        int[] dp = new int[N + 1]; // N이 1일 때를 대비해 N+1로
        dp[0] = 1;

        int mod = 1000000007;

        for (int i = 1; i < N + 1; i++)
        {
            dp[i] = dp[i - 1]; // A만 쓸 때의 조합
            if (i >= M)
            {
                dp[i] = (dp[i - 1] + dp[i - M]) % mod; // B도 쓸 때의 조합
            }
        }

        Console.WriteLine(dp[N]);
    }
}
