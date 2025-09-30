using System;

class BJ
{
    static void Main()
    {
        var line = Console.ReadLine().Split(" ");
        string N = line[0];
        int B = int.Parse(line[1]);
        
        int num = N.Length;
        long result = 0; 

        for (int i = num - 1; i > -1; i--)
        {
            char ch = N[i];
            int temp;

            if (Char.IsDigit(ch))
            {
                temp = ch - '0';
            }
            else
            {
                temp = ch - 'A' + 10; 
            }

            result += temp * (long)Math.Pow(B, num - i - 1);
        }

        Console.WriteLine(result);
    }
}
