using System;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int N = line[0]; int K = line[1];
        
        int cnt = 0;
        int fac = 0;
        bool find = false;
        while(fac<=N)
        {
            fac++;
           
            if(N%fac==0)
            {
                cnt++;
            }
            if(cnt==K)
            {
                find = true;
                break;
            }
        }
        
        if(find)
        {
            Console.WriteLine(fac);
        }
        else
        {
            Console.WriteLine("0");
        }
        
    }
}