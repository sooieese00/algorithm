using System;
using System.Text.RegularExpressions;

public class Solution 
{
    public string solution(string new_id)
    {
        new_id = new_id.ToLower();

        new_id = Regex.Replace(new_id, @"[^a-z0-9\-_.]", "");
        // 대괄호 안의 ^ : 부정, 괄호 안의 문자가 아닌 것을 찾음
        // a-z0-9: 소문자 알파벳, 숫자
        // \- : -는 이스케이프 문자 필요
        // . : 대괄호 안의 마침표는 마침표로 인식
        
        new_id = Regex.Replace(new_id, @"[.]{2,}", ".");
        // {2,} : 바로 앞의 요소가 2개 이상 반복되는 경우 의미

        new_id = new_id.Trim('.');
        // Trim() : 기본은 문자열 양쪽의 공백 문자 제거
        // Trim('.') : 문자열 양쪽의 마침표 문자 제거

        if (new_id == "")
        {
            new_id = "a";
        }

        if (new_id.Length>15)
        {
            new_id = new_id.Substring(0, 15);
            // Substring(startIndex, length);
            // 어디서부터 몇 글자를 자를지 지정
        }

        new_id = new_id.Trim('.');

        while(new_id.Length<3)
        {
            new_id +=new_id[^1];
            // ^1 : 뒤에서 첫번째 요소 의미
            // 마지막 글자를 문자열 끝에 덧붙임
        }

        return new_id;
    }

}