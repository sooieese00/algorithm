using System;
using System.Linq;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        (int a, int b, int c) = (line[0], line[1], line[2]);
        if(a==b && b==c)
        {
            Console.WriteLine(10000+a*1000);
        }
        else if(a==b || b==c || c==a)
        {
            int k = 0;
            k = ((a==b||c==a)?a:b);
            Console.WriteLine(1000+k*100);
        }
        else{
            Console.WriteLine(line.Max()*100);
        }
            
        
    }
}