using System;

class BJ
{
    static void Main()
    {
        int min = -1;
        int h= -1; int c = -1;
        
        for(int i= 0; i<9; i++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            for(int j = 0; j<9; j++)
            {
                int num = line[j];
                if(num>min)
                {
                    min = num;
                    h = i; c = j;
                }
            }
        }
        Console.WriteLine(min);
        Console.WriteLine($"{h+1} {c+1}");
    }
}