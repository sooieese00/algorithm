// 1번:3, 2번: 3+2=5, 3번: 5+4=9, 4번: 9+8 = 17
// 앞+1,2,4,8,16,32,,,

using System;

class BJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int start = 2;
 
        for(int i = 0; i<N; i++)
        {
            int bin = (int)Math.Pow(2, i);
            start = start+bin;
        }
        
        Console.WriteLine(start*start);
        
    }
}