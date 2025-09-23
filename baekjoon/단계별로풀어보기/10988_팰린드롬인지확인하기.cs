using System;

class BJ
{
    static void Main()
    {
        string word = Console.ReadLine();
        int l = word.Length;
        bool pel = true;

        for(int i=0; i<l/2; i++)
        {
            if(word[i]!=word[l-1-i])
            {
                        pel = false;
                        break;
            }
        }
        
        Console.Write(Convert.ToInt16(pel));
            
    }
}
                              