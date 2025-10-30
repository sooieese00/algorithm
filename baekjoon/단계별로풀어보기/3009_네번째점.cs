// x리스트와 y리스트 만들기
// 같은게 있다면 넘어가고, 같은게 없다면 그 값 출력

using System;

class BJ
{
    static void Main()
    {
        int[] xList = new int[3];
        int[] yList = new int[3];
        
        for(int i = 0; i<3; i++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            xList[i] = line[0];
            yList[i] = line[1];
        }
        
        

        int x= xList[0];
        int xResult= x;
        if(x==xList[1])
        {
            xResult = xList[2];
        }
        else if(x==xList[2])
        {
            xResult = xList[1];
        }

        
        int y = yList[0];
        int yResult = y;
        if(y==yList[1])
        {
            yResult = yList[2];
        }
        else if(y==yList[2])
        {
            yResult = yList[1];
        }
        
        Console.WriteLine($"{xResult} {yResult}");

    }
}