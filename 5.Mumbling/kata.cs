/* This time no story, no theory. The examples below show you how to write function accum:
Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt" */

//C#

using System;

public class Accumul 
{
  public static String Accum(string s) 
  {
    string s1 = "";
    string fs = "";
    
    for (int i = 0; i < s.Length; i++)
    {
        fs += char.ToUpper(s[i]);
        s1 = s1 + fs + new String(char.ToLower(s[i]), i);
        fs = "";
        if (i < s.Length-1)
        s1 = s1 + "-";
    }
    return s1;
  }
}
