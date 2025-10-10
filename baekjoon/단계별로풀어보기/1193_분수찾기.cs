// 몇번째 껍질인지 구하기
// 1, 2, 3, 4, ... => 1, 3, 6, 10
// 그 중에서 그것에 따라서 분모++, 분자++ 이런 식으로 분수 찾기

using System;

class BJ
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        
        int start = 1;
        int cnt = 1;
        
        // X가 속한 대각선 찾기
        while (X > start)
        {
            cnt++;
            start += cnt;
        }
        
        // X가 해당 대각선에서 몇 번째인지
        int diff = X - (start - cnt);

        int ja, mo;

        if (cnt % 2 == 0)  
        {
            ja = diff;
            mo = cnt - diff + 1;
        }
        else    
        {
            ja = cnt - diff + 1;
            mo = diff;
        }

        Console.WriteLine($"{ja}/{mo}");
    }
}
