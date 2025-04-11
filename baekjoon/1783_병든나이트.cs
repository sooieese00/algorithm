/*
(2,1)
(1,2)
(-1,2)
(-2,1)

N=1 => 1칸
N=2 => (1,2)(-1,2)오른쪽으로 두 칸씩만 가능, 4회 미만으로 움직여야함 : Min(4, M+1/2)
N=3 => 4가지를 모두 쓴다면 M>=7이어야함
    M<7 => min(4,M) 
    M>=7 => 2회만 오른쪽으로 두 칸 움직이고, 나머지는 한칸씩 : M-2  
*/


class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int N = int.Parse(inputs[0]);
        int M = int.Parse(inputs[1]);
        int result = 0;
        
        if (N==1)
        {
            result = 1;
        }
        else if(N==2)
        {
            result = Math.Min(4, (M+1)/2);
        }
        else if(N>=3)
        {
            if(M<7)
            {
                result = Math.Min(4, M);
            }else
            {
                result = M-2;
            }
        }
        Console.WriteLine(result);
    }
}