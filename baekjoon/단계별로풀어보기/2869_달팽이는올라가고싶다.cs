using System;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), long.Parse);
        (long A, long B, long V) = (line[0], line[1], line[2]);
        
        long day = (long)Math.Ceiling((double)(V-B)/(A-B));

        Console.WriteLine(day);
    }
}