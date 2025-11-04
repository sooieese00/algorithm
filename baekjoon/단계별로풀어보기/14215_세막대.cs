// 삼각형이 되는지 확인
// => 된다면 : 바로 더해서 출력
// => 안된다면 : 가장 큰 거를 줄여서 더해서 출력

using System;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        Array.Sort(line); //오름차순 정렬
        
        (int a, int b, int c) = (line[0], line[1], line[2]);
        if(a+b<=c)
        {
            c= a+b-1;
        }

        Console.WriteLine(a+b+c);
        
        
        
    }
}