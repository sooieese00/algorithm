using System;

class Program
{
    static void Main()
    {
        string[] words = new string[5];  
        int max = 0;

        // 입력 받기
        for (int i = 0; i < 5; i++)
        {
            string line = Console.ReadLine();
            words[i] = line;

            if (line.Length > max)
            {
                max = line.Length;
            }
        }

        string result = "";

        // 세로 읽기
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (words[j].Length<i+1) 
                {
                    continue;
                }
                result += words[j][i];
            }
        }

        Console.WriteLine(result);
    }
}