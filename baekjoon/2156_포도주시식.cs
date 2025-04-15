// dp[i] : i번째 잔까지 마실 수 있는 최대 포도주 양
// i잔을 마시지 않을 때 => dp[i-1]
// i잔을 마실 때
//      i-1잔을 안마신다면 => dp[i-2]+ wine[i]
//      i-1잔을 마신다면 (i-2잔은 안마셔야함)=> dp[i-3] + wine[i-1] + wine[i]

class BOJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] wine = new int[N];
        int[] dp = new int[N];

        for (int i = 0; i<N; i++)
        {
            wine[i] = int.Parse(Console.ReadLine());
        }

        if (N>=1) dp[0] = wine[0];
        if (N>=2) dp[1] = wine[0] + wine[1];
        if (N>=3)
        {
            dp[2] = Math.Max(dp[1], Math.Max(wine[0]+wine[2], wine[1]+wine[2]));

            for(int i = 3; i<N; i++)
            {
                dp[i] = Math.Max(dp[i-1], Math.Max(dp[i-2]+wine[i], dp[i-3] + wine[i-1] + wine[i]));
            }

        }

        Console.WriteLine(dp[N-1]);

    }
}