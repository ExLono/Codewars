/* ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
If the function is passed a valid PIN string, return true, else return false. */

//C#

using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    int pinchek = 0;
    int mod = 0;
    pin = Regex.Replace(pin,@"[^0-9A-Za-z]+", "a");
    
    if(!Int32.TryParse(pin, out pinchek))
        return false;
    if (pinchek < 0)
        return false;
    foreach (char i in pin)
      mod++;   
    if ((mod == 4) || (mod == 6))
      return true;
    else 
      return false;
  }
}
