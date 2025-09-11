using System;

class BJ
{
    static void Main()
    {
        var num_temp = Console.ReadLine();
        var line_temp = Console.ReadLine();
        var find_temp = Console.ReadLine();
        
        int num = int.Parse(num_temp);
        var numbers = line_temp.Split(' ');
        int find = int.Parse(find_temp);
        
        int cnt= 0;
        for(int i = 0; i<num; i++)
        {
            if(find==int.Parse(numbers[i]))
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }
}