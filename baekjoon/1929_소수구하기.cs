using System;

class BOJ
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int M = int.Parse(inputs[0]);
        int N = int.Parse(inputs[1]);
        
        for(int i = M; i<N+1; i++)
        {
            if(IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool IsPrime(int num)
    {
        // 1,2 따로 판별해주기기
        if(num==1){return false;}
        if(num==2){return true;}
       
       // num의 제곱근까지만 나눠보는 것에 주의의
        for(int j = 2; j*j<=num; j++)
        {
                if (num%j==0)
                {
                    return false;
                }
        }
        return true;
    }
}