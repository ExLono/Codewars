/* Given an array of integers, find the one that appears an odd number of times.
There will always be only one integer that appears an odd number of times. */

//C#

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      int mod = 0;
      int pogq = 0;
      for (int i = 0; i < seq.Length; i++)
      {
        for (int j = 0; j < seq.Length; j++)
          {
            if (seq[j]==seq[i])
            mod++;
          } 
        if (mod%2!=0)
        {
          pogq = seq[i];
          break;
        }
      }
      return pogq;
      } 
   }
}
