/* The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.

Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.

Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?

Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. Otherwise return NO. */

//C#

using System;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
          foreach (int i in peopleInLine)
          Console.WriteLine(i);
        var d25 = 0;
        var d50 = 0;
        for (int i = 0; i < peopleInLine.Length; i++)
        {
            if (peopleInLine[i]==25)
            {
                d25 += 1;
                continue;
            }     
            else if ((peopleInLine[i]==50) && (d25 >= 1) )
            {
                d25 -= 1; d50 += 1;
            }
                
            else if (((peopleInLine[i]==100) && ((d25 >= 1) && (d50 >=1)))) 
            {
                d25 -= 1; d50 -= 1;
            }
                
            else if ((peopleInLine[i]==100) && (d25 >= 3)) 
                d25 -=3;
                
            else
                return "NO";
            
        }
        return "YES";
        }
    }
