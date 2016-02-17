using System;
using System.Linq;
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

      for(int i =0; i < stringArray.Length; i++)
      {
        // Console.WriteLine(stringArray[i]);
        if (stringArray[i] == find)
        {
          Console.WriteLine(stringArray[i]);
          Console.WriteLine(i);
          Console.WriteLine(replace);
          stringArray.SetValue(replace, i);
        }
      }
      string stringHolder = String.Join(" ", stringArray);
      return stringHolder;

    }

  }
}
