using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;
using System.Collections.Generic;
using GildedRose;
using GildedRose.Items;

namespace GildedRose.Tests
{

    [TestClass]
    public class ShopTests
    {
        private Shop shop;
        private List<Item> items = new List<Item>()
        {
            new GenericItem("Wand", 9, 8),
            new GenericItem("Sword", -1, 8),
            new GenericItem("Shield", -1, 1),
            new AgingItem("Aged Brie", 5, 4),
            new AgingItem("Aged Brie", 5, 50),
            new LegendaryItem("Sulfuras", 5, 80),
            new EventItem("Backstage Pass", 15, 10),
            new EventItem("Backstage Pass", 10, 10),
            new EventItem("Backstage Pass", 5, 10),
            new EventItem("Backstage Pass", 0, 10),
   
        };

        [TestInitialize]
         public void Setup()
         {
            this.shop = new Shop(this.items);
            this.shop.UpdateQuality();
         }

         [TestMethod]
        public void Should_UpdateItemProperties()
        {
            Assert.AreEqual(8, this.shop.Items[0].SellIn);
            Assert.AreEqual(7, this.shop.Items[0].Quality);
        }


        [TestMethod]
        public void Should_DecreaseQualityTwiceAsFastAfterExpiration()
        {
          Assert.AreEqual(6, this.shop.Items[1].Quality);
        }

        [TestMethod]
        public void Should_NotHaveNegativeQuality()
        {
          Assert.AreEqual(0, this.shop.Items[2].Quality);
        }

        [TestMethod]
        public void Should_IncreaseAgedBrieQuality()
        {
           Assert.AreEqual(50, this.shop.Items[3].Quality);
        }

      [TestMethod]
        public void Should_NotHaveNegativeQualityTwiceAsFastExpiration()
       {

          Assert.AreEqual(6, this.shop.Items[1].Quality);
       }

      [TestMethod]
        public void Should_NotUpdateLegendaryItemProperties()
        {
           Assert.AreEqual(5, this.shop.Items[5].SellIn);
           Assert.AreEqual(80, this.shop.Items[5].Quality);
        }

       [TestMethod]
        public void Should_IncreaseBackstagePassQualityToZeroBeforeEvent()
        {
           Assert.AreEqual(12, this.shop.Items[7].Quality);
        }

       [TestMethod]
        public void Should_IncreaseBackstagePassQualityByThreeFiveDayesterEvent()
        {
           Assert.AreEqual(13, this.shop.Items[8].Quality);
        }

       [TestMethod]
        public void Should_IncreaseBackstagePassQualityToZeroAfterEvent()
        {
           Assert.AreEqual(0, this.shop.Items[9].Quality);
        }
    }
}