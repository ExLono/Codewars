/* Once upon a time, on a way through the old wild mountainous west,…
… a man was given directions to go from one point to another. The directions were "NORTH", "SOUTH", "WEST", "EAST". Clearly "NORTH" and "SOUTH" are opposite, "WEST" and "EAST" too.

Going to one direction and coming back the opposite direction right away is a needless effort. Since this is the wild west, with dreadfull weather and not much water, it's important to save yourself some energy, otherwise you might die of thirst!

How I crossed a mountainous desert the smart way.
The directions given to the man are, for example, the following (depending on the language):

["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"].
or
{ "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
or
[North, South, South, East, West, North, West]
You can immediatly see that going "NORTH" and immediately "SOUTH" is not reasonable, better stay to the same place! So the task is to give to the man a simplified version of the plan. A better plan in this case is simply:

["WEST"]
or
{ "WEST" }
or
[West] */

//C#

using System;
using System.Collections.Generic;
public class DirReduction {
  
    public static string[] dirReduc(String[] arr) 
    {
        List<string> list1 = new List<string>(arr);
        int sizelist1 = list1.Count;
        for (int i = 0; i < sizelist1-1; i++){
          if ( ((list1[i]=="EAST") && (list1[i+1]=="WEST")) || ((list1[i]=="WEST") && (list1[i+1]=="EAST")) ||
          ((list1[i]=="SOUTH") && (list1[i+1]=="NORTH")) || ((list1[i]=="NORTH") && (list1[i+1]=="SOUTH")) ) 
          {
          list1.RemoveAt(i+1);
          list1.RemoveAt(i);
          sizelist1 = sizelist1-2;
          i=-1;
          }
    }
      string[] arr1 = list1.ToArray();
      return arr1;
    }
}
