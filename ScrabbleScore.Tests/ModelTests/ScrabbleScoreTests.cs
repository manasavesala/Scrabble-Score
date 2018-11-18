using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    [TestMethod]
    public void IsScore_same()
    {
      //Arrange
      string name = "QQQ";

      Assert.AreEqual(30, ScrabbleScore.Models.ScrabbleScore.GiveScrabbleScore(name));

    }
     [TestMethod]
    public void IsScore_same2()
    {
      //Arrange
      string name = "QQQZZ";

      Assert.AreEqual( 50, ScrabbleScore.Models.ScrabbleScore.GiveScrabbleScore(name));

    }
     [TestMethod]
    public void IsScore_same3()
    {
      //Arrange
      string name = "AAA";

      Assert.AreEqual( 3, ScrabbleScore.Models.ScrabbleScore.GiveScrabbleScore(name));

    }

  }

}
