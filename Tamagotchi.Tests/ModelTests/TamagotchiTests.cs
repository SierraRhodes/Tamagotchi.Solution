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
  }
}