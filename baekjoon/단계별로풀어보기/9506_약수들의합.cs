using System;
using System.Collections.Generic;

class BJ
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == -1) break;

            List<int> numbers = new List<int>();
            int total = 0;

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    numbers.Add(i);
                    total += i;

                    int pair = n / i;
                    if (pair != i && pair != n) // 루트값, n 제외
                    {
                        numbers.Add(pair);
                        total += pair;
                    }
                }
            }

            numbers.Sort();

            if (total == n)
            {
                Console.Write($"{n} = ");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);
                    if (i != numbers.Count - 1) Console.Write(" + ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{n} is NOT perfect.");
            }
        }
    }
}
