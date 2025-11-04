using System;
using System.Linq;

class BJ
{
    static void Main()
    {
        while (true)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            if (line.Contains(0))
            {
                break;
            }

            Array.Sort(line); // 오름차순 정렬

            (int a, int b, int c) = (line[0], line[1], line[2]);
            if (c >= a + b)
            {
                Console.WriteLine("Invalid");
                continue;
            }

            if (a == b && b == c)
            {
                Console.WriteLine("Equilateral");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
}
