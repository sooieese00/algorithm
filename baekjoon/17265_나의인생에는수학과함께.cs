/*
모든 경우의 수 중 최댓값과 최솟값 찾기
오른쪽, 아래쪽만 가능 dx = {0,1}, dy = {1,0}
DFS(새로운 x, 새로운 y, 지금까지 숫자, 연산자)
    cell이 연산자일 때: 연산자를 바꿈
    cell이 숫자일 때: 연산자와 계산
*/

using System;

class BOJ
{
    static string[,] board;
    static int N;
    static int max = int.MinValue;
    static int min = int.MaxValue;
    static int[] dx = { 0, 1 };
    static int[] dy = { 1, 0 };

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        board = new string[N,N];

        // board에 주어진 값 저장
        for (int i = 0; i<N; i++)
        {
            var line = Console.ReadLine().Split(' ');
            for (int j = 0; j<N; j++)
            {
                board[i, j] = line[j];
            }
        }

        DFS(0,0, int.Parse(board[0,0]), "");
        Console.WriteLine($"{max} {min}");
    }

    static void DFS(int x, int y, int curr, string op)
    {
        // 전역변수 max와 min을 업데이트
        if (x==N-1 && y==N-1)
        {
            max = Math.Max(max, curr);
            min = Math.Min(min, curr);
            return;
        }

        for (int i = 0; i<2; i++)
        {
            // 다음 칸으로
            var nx = x + dx[i];
            var ny = y + dy[i];

            if (nx<N && ny<N)
            {
                string cell = board[nx, ny];
                if (IsOperator(cell))
                {
                    // 연산자일 때는 연산자 칸의 인덱스와 해당 연산자로
                    DFS(nx, ny, curr, cell);
                } else
                {
                    // 숫자일 때는 1)숫자 칸의 인덱스, 2)이전 인덱스로 새로 계산한 값, 3)연산자 초기화 
                    int num = int.Parse(cell);
                    int newcurr = getCalculate(curr, num, op);
                    DFS(nx, ny, newcurr, "");
                }
            }
        }
    }

    static bool IsOperator(string s)
    {
        if (s=="+" || s=="-" || s=="*")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int getCalculate(int a, int b, string op)
    {
        int result = 0;

        switch (op)
        {
            case "+":
                result = a+b;
                break;
            case "-":
                result = a-b;
                break;
            case "*":
                result = a*b;
                break;
        }

        return result;
    }
}