// 총 바구니 개수, 몇 번
// i-> j (인덱스 조심)

using System;

class BJ
{
    static void Main()
    {
        var first = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        (int N, int M) = (first[0], first[1]);
        
        int[] basket = new int[N];
        for(int i = 0; i<N; i++)
        {
            basket[i] = i+1;
        }

        for(int k = 0; k<M; k++)
        {
            var line =  Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            (int i, int j) =(line[0], line[1]);
            Array.Reverse(basket, i-1, j - i + 1);
        }
        
        Console.WriteLine(string.Join(" ", basket));
        
    }
}