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


  }
}
