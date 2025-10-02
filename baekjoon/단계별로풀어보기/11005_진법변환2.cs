// A 아스키코드 = 65
// 나눠서 10보다 작다 크다, 앞자리부터 구하기

using System;

class BJ
{
    static void Main()
    {
        var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        (int N, int B) = (input[0], input[1]);
        
        string result = "";
        while(N>0)
        {
        
            int k = N%B;
            if(k<10)
            {
                result += Convert.ToString(k);
            }
            else
            {
                result += (char)(k -10 +'A');
            }
            N = N/B;
           
        }
        
        char[] arr = result.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
}