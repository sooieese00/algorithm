// 해당 숫자가 몇번째 껍질에 있는지를 알면 됨
// 1, 6, 12, 18 => 1, 7, 19, 37
// 6의 배수
//  while문으로

using System;

class BJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int start = 1;
        int cnt= 1;
        
        while(N>start)
        {
            start += 6*cnt;
            cnt++;
        }
        
        Console.WriteLine(cnt);
    }
}