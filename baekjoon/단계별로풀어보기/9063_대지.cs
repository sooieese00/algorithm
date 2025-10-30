// 첫번째 숫자가 1이면 0출력
// 첫번째 숫자만큼 반복
// 가장 작은 x, 가장 큰 x, 가장 작은 y, 가장 큰 y 찾기

using System;
using System.Linq;
class BJ
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] xList = new int[N];
        int[] yList = new int[N];
        
        for(int i = 0; i<N ; i++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            xList[i] = line[0];
            yList[i] = line[1];
        }
        
        int xmin = xList.Min();
        int xmax = xList.Max();
        int ymin = yList.Min();
        int ymax = yList.Max();
        
        Console.WriteLine((xmax - xmin)*(ymax - ymin));
        
    }
}