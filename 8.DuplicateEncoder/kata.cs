/*he goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" */

//C#

using System;
public class Kata
{
  public static string DuplicateEncode(string word)
  {
    word = word.ToLower();
    var str = "";

        for (var i = 0; i < word.Length; i++)
        {
            if (word.LastIndexOf(word[i])==word.IndexOf(word[i]))
            str += '(';
            else
            str += ')';
        }
    
   
    return str;
  }
}
