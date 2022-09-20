using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
  [TestClass()]
  public class CardGameTests
  {
    [TestMethod()]
    public void LocateCardTest()
    {
      List<int> cards = new() { 64, 32, 16, 8, 4, 2, 1 };
      int query = 2;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(5, result);
    }
    [TestMethod()]
    public void LocateCardNotFoundTest()
    {
      List<int> cards = new() { 64, 32, 16, 8, 4, 2, 1 };
      int query = 10;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(-1, result);
    }
    [TestMethod()]
    public void LocateCardFirstTest()
    {
      List<int> cards = new() { 64, 32, 16, 8, 4, 2, 1 };
      int query = 64;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(0, result);
    }
    [TestMethod()]
    public void LocateCardLastTest()
    {
      List<int> cards = new() { 64, 32, 16, 8, 4, 2, 1 };
      int query = 1;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(6, result);
    }
    [TestMethod()]
    public void LocateCardLongTest()
    {
      List<int> cards = new() 
        { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
      int query = 256;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(2, result);
    }
    [TestMethod()]
    public void LocateCardEmptyTest()
    {
      List<int> cards = new()
        {  };
      int query = 256;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(-1, result);
    }
    [TestMethod()]
    public void LocateCardQueryEmptyTest()
    {
      List<int> cards = new()
        { 1024, 512, 256, 128, 64, 64, 64, 40, 30, 30, 10, 5, 1, 1 };
      int query = 64;
      var result = CardGame.LocateCard(cards, query);
      Assert.AreEqual(4, result);
    }
  }
}