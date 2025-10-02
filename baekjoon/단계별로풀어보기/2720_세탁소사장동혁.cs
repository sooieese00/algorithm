// 거스름돈 = Q*i + D*j + N*k + P*l

using System;

class BJ
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        string result = "";
        
        for(int it = 0; it < T ; it++)
        {
            int num = int.Parse(Console.ReadLine());
            int i = num/25;
            num = num - i*25;
            int j = num/10;
            num = num - j*10;
            int k = num/5;
            num = num - k*5;
            int l = num;
            
            result += $"{i} {j} {k} {l}\n";
        }
        
        Console.WriteLine(result.TrimEnd());
           
    }
    
}