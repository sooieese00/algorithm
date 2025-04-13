using System;

// 빗물의 기준점을 어디까지로 정할지: 주어진 숫자 중 최대값 구하기
// 한 점에 대해서 DFS구하면서 visited 불리언 걸어두기
// 다음 점은 visited가 false인 점부터 시작
// 개수를 구하는 거니깐 매 빗물바다 안전영역의 개수 초기화해서 넣어두기
// 안전영역의 개수 최대값 return

class Program
{
    static int[,] map;
    static bool[,] visited;
    static int N;
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        map = new int[N, N];
        int maxHeight = 0;
        
        // 주어진 지형정보를 map에 저장
        // 잠기는 높이의 최대기준점maxHeight 정하기
        for (int i = 0; i<N; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int j = 0; j < N; j++)
            {
                map[i, j] = int.Parse(line[j]);
                if (map[i, j] > maxHeight)
                {
                    maxHeight = map[i, j];
                }
            }
        }
        
        int maxSafeZone = 0;
        
        for (int h = 0; h < maxHeight; h++)
        {
            visited = new bool[N,N]; // 기본값 false로 채워진 상태
            int safeZone = 0;
                
            for (int i = 0; i<N ; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    if (!(visited[i, j]) && map[i, j]>h)
                    {
                        DFS(i, j, h);
                        safeZone++;
                    }
                }
                maxSafeZone = Math.Max(safeZone, maxSafeZone);
            }
        }
        Console.WriteLine(maxSafeZone);
    }
    
    // map의 boolean을 변경해두는 함수
    static void DFS(int x, int y, int h)
    {
        visited[x, y]  = true;
        for (int i= 0; i<4; i++)
        {
            // x += dx[i];
            // y += dy[i];
            // for문을 돌면서는 x좌표가 똑같아야하니깐 위처럼 누적하면 안 됨!
            int nx = x + dx[i];
            int ny = y + dy[i];
            
            if (nx>=0 && ny>=0 && nx<N && ny<N)
            {
                if (!visited[nx, ny] && map[nx, ny]>h)
                {
                    DFS(nx, ny, h);
                }
            }
        }
    }
}
