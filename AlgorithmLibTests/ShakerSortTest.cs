using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLib.Tests
{
    [TestClass()]
    public class ShakerSortTests
    {
        const int countElements = 1000;
        [TestMethod]
        public void ShakerSortIntTest()
        {
            //assigne
            ShakerSort<int> shaker = new ShakerSort<int>();
            List<int> items = new List<int>();
            Random random = new Random();
            for (int i = 0; i < countElements; i++)
                items.Add(random.Next(-50, 50));

            shaker.Items.AddRange(items);
            items.Sort();

            //act
            shaker.Sort();

            //assert
            for (int i = 0; i < countElements; i++)
                Assert.AreEqual(items[i], shaker.Items[i]);
        }
        [TestMethod]
        public void ShakerSortDoubleTest()
        {
            //arrange
            ShakerSort<double> shaker = new ShakerSort<double>();
            List<double> items = new List<double>();
            Random random = new Random();
            for (int i = 0; i < countElements; i++)
                items.Add(random.NextDouble() * (-50) + random.NextDouble() * 50);

            shaker.Items.AddRange(items);
            items.Sort();

            //act
            shaker.Sort();

            //assert
            for (int i = 0; i < countElements; i++)
                Assert.AreEqual(items[i], shaker.Items[i]);
        }
    }
}