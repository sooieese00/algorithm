 // 6개의 숫자 주어짐
// 하드코딩으로 [1,1,2,2,2,8]
// 하드코딩에서 주어진 숫자를 각각 빼기
// string.Join(하드코딩, " ")로 출력

using System;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int[] target = {1,1,2,2,2,8};
        int[] result = new int[6];
        for(int i = 0; i<6; i++)
        {
            result[i] = target[i] - line[i];
        }
        
        Console.WriteLine(string.Join(" ", result));
        
    }
}