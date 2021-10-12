using KerridgeCommercialSystem.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using KerridgeCommercialSystem.Classes;
using System.Collections.Generic;

namespace KerridgeSystem.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            List<Item> items = new List<Item>();
            double expectedPrice = 13.69;
            Item _item = new Item("Milk", 13.04m,true, KerridgeCommercialSystem.Enums.ItemCategory.Books,0.65m);
            items.Add(_item);
            //Act
            _item.CalculateTax(items);

            //Assert
            decimal actual = _item.Price;
            Assert.AreEqual(expectedPrice, actual, "Calculated incorrectly");
        }
    }
}
