using System;
using System.Collections.Generic;
using Xunit;

namespace FindAndReplaceNS
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FandR_Sentence()
    {
      FindAndReplace test = new FindAndReplace();
      Assert.Equal("Hello dog", test.FandR("Hello cat", "cat", "dog"));
    }
    [Fact]
    public void FandR_Partial()
    {
      FindAndReplace test = new FindAndReplace();
      Console.WriteLine(test.FandR("I am walking my cat to the cathedral", "cat", "dog")); 
      Assert.Equal("I am walking my dog to the doghedral", test.FandR("I am walking my cat to the cathedral", "cat", "dog"));
    }

  }
}
