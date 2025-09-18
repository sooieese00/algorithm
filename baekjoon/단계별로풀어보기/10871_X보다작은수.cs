using System;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        (int N, int X) = (line[0], line[1]);
        var A = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        
        string result = "";
        for (int i = 0; i < N; i++)
        {
            if (A[i] < X)
            {
                result += A[i].ToString() + " ";
            }
        }
        
        Console.WriteLine(result.TrimEnd());
    }
}
