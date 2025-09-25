using System;

class BJ
{
    static void Main()
    {
        var line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        (int N, int M)  = (line[0], line[1]);
        int[,] Array_A = new int[N, M];
        int[,] Array_B = new int[N, M];
        
        for(int i = 0; i<N; i++)
        {
            var words = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            for(int j = 0; j<M ; j++)
            {
                Array_A[i,j] = words[j];
            }
        }
        for(int i = 0; i<N; i++)
        {
            var words = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            for(int j = 0; j<M ; j++)
            {
                Array_B[i,j] = words[j];
            }
        }
        
        
        for(int i = 0; i<N; i++)
        {
            string result = "";
            for(int j = 0; j<M ; j++)
            {
                int num = Array_A[i,j]+Array_B[i,j];
                result += Convert.ToString(num)+" ";
            }
            Console.WriteLine(result.Trim());
        }

    }
}