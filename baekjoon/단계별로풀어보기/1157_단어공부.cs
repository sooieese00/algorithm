// 알파벳 개수의 배열을 만들어둔다. 
// 등장할 때마다 알파벳(대소문자 상관없이 같은 인덱스) => 아스키코드 인덱스로 변환 => 해당 인덱스에 ++
// 가장 큰 숫자가 있는 인덱스 => 알파벳으로 변경
// 가장 큰 숫자가 여러개라면 ? 
// 하나라면 해당 값을 대문자로 

using System;

class BJ
{
    static void Main()
    {
        string line = Console.ReadLine();
        line = line.ToUpper();
        int[] alpha = new int[26];
        for(int i = 0; i<26; i++)
        {
            alpha[i] = 0;
        }
        
        foreach(char c in line)
        {
            int ascii = (int)c;
            alpha[ascii-65]+=1;
        }
        
        int idx = -1;
        int max = -1;
        int num = 0;
        for(int i = 0; i<26; i++)
        {
            if(alpha[i]>max)
            {
                max = alpha[i];
                idx = i;
            }
        }
        
         for(int i = 0; i<26; i++)
        {
            if(alpha[i]==max)
            {
                num++;
            }
        }
        
        if(num>1)
        {
            Console.WriteLine("?");
        }
        else{
            Console.WriteLine((char)(idx+65));
        }
           
        
        
    }
}