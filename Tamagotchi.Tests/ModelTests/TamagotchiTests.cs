using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class TamagotchiTests 
  {
    [TestMethod]
    public void InstantiateTamagotchi_CreateInstance_ReturnInstance()
    {
      TamagotchiPet testTamagotchi = new TamagotchiPet("Yoshi", 100, 100, 100);

      Assert.AreEqual("Yoshi", testTamagotchi.Name);
      Assert.AreEqual(100, testTamagotchi.Food);
      Assert.AreEqual(100, testTamagotchi.Attention);
      Assert.AreEqual(100, testTamagotchi.Rest);
      
    }
    [TestMethod]
    public void FeedTamagotchi_IncreaseFood_ReturnUpdatedValue()
    {
      TamagotchiPet testTamagotchi = new TamagotchiPet("Yoshi", 100, 100, 100);

      testTamagotchi.Feed();

      Assert.AreEqual(110, testTamagotchi.Food);
      Assert.AreEqual(95, testTamagotchi.Attention);
      Assert.AreEqual(95, testTamagotchi.Rest);
    }
    [TestMethod]
    public void GiveAttention_IncreaseAttention_ReturnUpdatedValue()
    {
      TamagotchiPet testTamagotchi = new TamagotchiPet("Yoshi", 100, 100, 100);

      testTamagotchi.giveAttention();

      Assert.AreEqual(90, testTamagotchi.Food);
      Assert.AreEqual(110, testTamagotchi.Attention);
      Assert.AreEqual(95, testTamagotchi.Rest);
    }
    [TestMethod]
    public void LetRest_GiveTamagotchiRest_ReturnUpdatedValue()
    {
      TamagotchiPet testTamagotchi = new TamagotchiPet("Yoshi", 100, 100, 100);

      testTamagotchi.letRest();

      Assert.AreEqual(80, testTamagotchi.Food);
      Assert.AreEqual(90, testTamagotchi.Attention);
      Assert.AreEqual(120, testTamagotchi.Rest);
    }
  }
}