// 첫 줄 개수
// 둘째 줄 split=>int=>최댓값 고르기
// 모든 값을 점수/M*100
// 새로운 평균 구하기

using System;
using System.Linq;

class BJ
{
    static void Main()
    {
        double num = int.Parse(Console.ReadLine());
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        double max = line.Max();
        
        double total = 0;
        foreach(double score in line)
        {
            double new_score = score/max*100;
            total +=new_score;
        }
        
        Console.WriteLine(total/num);
           
    }
}