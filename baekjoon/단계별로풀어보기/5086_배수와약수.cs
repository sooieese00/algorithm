using System;

class BJ
{
    static void Main()
    {
        while(true)
        {
            var line = Array.ConvertAlll(Console.ReadLine().Split(" "), int.Parse);
            int A = line[0]; int B = line[1];
            if(A==0)
            {
                break;
            }
            
            if(A%B==0)
            {
                Console.WriteLine("multiple");
            }
            else if(B%A==0)
            {
                Console.WriteLine("factor");
            }
            else
            {
                Console.WriteLine("neither");
            }
            
        }
        
    }
}