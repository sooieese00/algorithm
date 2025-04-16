using System;

public class Solution {
    public string solution(string s){
        s = s.ToLower();
        char[] arr = s.ToCharArray();

        if (arr.Length>0 && Char.IsLetter(arr[0]))
        {
            arr[0] = Char.ToUpper(arr[0]);
        }

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i-1] == ' ' && Char.IsLetter(arr[i]))
            {
                arr[i] = Char.ToUpper(arr[i]);
            }
        }

        return new string(arr);
    }
}