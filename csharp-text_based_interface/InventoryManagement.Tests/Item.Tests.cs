using NUnit.Framework;
using System;

namespace InventoryLibrary.Tests
{
    public class Item_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Item_Inheritance()
        {
            Assert.IsTrue(typeof(Item).IsSubclassOf(typeof(BaseClass)));
            Item it = new Item();
            Assert.IsTrue(it.GetType().IsSubclassOf(typeof(BaseClass)));
        }

        [Test]
        public void Item_Instance_Properties(
            [Values("name", "description", "price", "tags")] string prop)
        {
            Item it = new Item();
            Type myType = it.GetType();

            Assert.IsNotNull(myType.GetProperty(prop));
        }

        [Test]
        public void Item_Set_Price()
        {
            Item it = new Item();
            it.price = 7.28f;
            Assert.AreEqual(7.28f, it.price);
            it.price = 7.28888f;
            Assert.AreEqual(7.28f, it.price);
            it.price = 7f;
            Assert.AreEqual(7f, it.price);
            it.price = 7.28f;
            Assert.AreEqual(7.28f, it.price);
            it.price = 7.99f;
            Assert.AreEqual(7.99f, it.price);
            it.price = 7.9f;
            Assert.AreEqual(7.9f, it.price);
            it.price = 7.469f;
            Assert.AreEqual(7.47f, it.price);
            it.price = 7.39f;
            Assert.AreEqual(7.39f, it.price);
        }

        [Test]
        public void Item_Name()
        {
            Item it = new Item();
            Assert.IsNotNull(it.name);
            Assert.AreEqual(it.name, "Item");
            Item it2 = new Item("Maria");
            Assert.AreEqual(it2.name, "Maria");
            Item it3 = new Item();
            it3.name = "Crespo";
            Assert.AreEqual(it3.name, "Crespo");
        }
    }
}