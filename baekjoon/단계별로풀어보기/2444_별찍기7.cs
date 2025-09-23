// N번째 줄에 2*N-1개의 별

using System;

class BJ
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        
        for(int i = 0; i<r; i++)
        {
            Console.Write(new string(' ', r-i-1));
            Console.Write(new string('*', 2*i+1));
            Console.WriteLine();
        }
        
         for(int i = 0; i<r-1; i++)
        {
             Console.Write(new string(' ', i+1));
             Console.Write(new string('*', 2*r-3-2*i));
             Console.WriteLine();
        }
        
        
    }
}