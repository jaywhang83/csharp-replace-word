using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FindAndReplaceNS
{
  public class FindAndReplace
  {
    public string FandR(string sentence, string find, string replace)
    {
      string result = sentence.Replace(find, replace);
      return result;
    }

    public string FandRSingleWord(string sentence, string find, string replace)
    {
      string[] stringArray = sentence.Split(' ');
      // Regex RGX = new Regex();

      for(int i =0; i < stringArray.Length; i++)
      {
        // Console.WriteLine(stringArray[i]);
        string s = Regex.Replace(stringArray[i], @"[^\W]", "");
        Console.WriteLine(s);
        if (String.Equals(Regex.Replace(stringArray[i], @"[^\w]", ""), Regex.Replace(find,  @"[^\w]", "" )))
        {

          Console.WriteLine(stringArray[i]);
          Console.WriteLine(i);
          Console.WriteLine(replace);
          stringArray.SetValue(s+replace, i);
        }
      }
      string stringHolder = String.Join(" ", stringArray);
      return stringHolder;

    }

  }
}
