// 바구니 1~N
// 공 1~N, 여러개씩

// N짜리 array하나 만들기, 0으로 채워넣기
// 횟수는 M번

// 배열의 해당 인덱스에 채워넣기(받아오는 값은 인덱스가 아닌 번호임에 주의)


using System;

class BJ
{
    static void Main()
    {
        var first_line = Console.ReadLine().Split();
        int N = int.Parse(first_line[0]);
        int M = int.Parse(first_line[1]);

        int[] baskets = new int[N];
        for (int r = 0; r < M; r++)
        {
            var line = Console.ReadLine().Split();
            int i = int.Parse(line[0]);
            int j = int.Parse(line[1]);
            int k = int.Parse(line[2]);

            for (int h = i - 1; h < j; h++)
            {
                baskets[h] = k;
            }
        }
        Console.WriteLine(string.Join(" ", baskets));
    }
}