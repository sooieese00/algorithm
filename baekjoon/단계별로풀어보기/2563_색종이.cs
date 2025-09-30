using System;

class BJ
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int[,] grid = new int[100,100]; 
        
        // 배열 초기화
        for(int i = 0; i<100; i++)
        {
            for(int j = 0; j<100; j++)
            {
                grid[i, j] = 0;
            }
        }
        
        // 입력 읽고 배열에 저장
        for(int i = 0; i< k ; i++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            (int x, int y) = (line[0], line[1]);
            for(int a = x; a<x+10; a++)
            {
                for(int b = y; b<y+10; b++)
                {
                    grid[a, b] = 1;
                }
            }
        }
        
        // 붙여진 넓이 세기
        int result = 0;
        for(int i = 0; i<100; i++)
        {
            for(int j = 0; j<100; j++)
            {
                if(grid[i, j] == 1)
                {
                    result++;
                }
            }
        }
        
        Console.WriteLine(result);
        
    }
}