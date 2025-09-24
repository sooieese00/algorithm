using System;

class BJ
{
    static void Main()
    {
        int it = int.Parse(Console.ReadLine());
        int num = 0;
        
        for(int i = 0; i<it; i++)
        {
            string word = Console.ReadLine();
            if(is_group(word))
            {
                num++;
            }
        }
        Console.WriteLine(num);
    }
    
    public static bool is_group(string word)
    {
        bool[] alpha = new bool[26];
 
        int l = word.Length;
        
        for(int i = 0; i<l ; i++)
        {
            if(i==0)
            {
                alpha[(char)(word[i])-97] = true;
            }
            else
            {
                if(word[i]==word[i-1])
                {
                    continue;
                }
                else
                {
                    if(alpha[(char)(word[i])-97])
                    {
                        return false;
                    }
                    else
                    {
                        alpha[(char)(word[i])-97] = true;
                    }
                }
            }
        }
        return true;
    }
}