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
    public class BubbleSortTests
    {
        const int countElements = 1000;
        [TestMethod]
        public void BubbleSortIntTest()
        {
            //assigne
            BubbleSort<int> bubble = new BubbleSort<int>();
            List<int> items = new List<int>();
            Random random = new Random();
            for (int i = 0; i < countElements; i++)
                items.Add(random.Next(-50, 50));

            bubble.Items.AddRange(items);
            items.Sort();

            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < countElements; i++)
                Assert.AreEqual(items[i], bubble.Items[i]);
        }

        [TestMethod]
        public void BubbleSortDoubleTest()
        {
            //arrange
            BubbleSort<double> bubble = new BubbleSort<double>();
            List<double> items = new List<double>();
            Random random = new Random();
            for (int i = 0; i < countElements; i++)
                items.Add(random.NextDouble()*(-50) + random.NextDouble() * 50);

            bubble.Items.AddRange(items);
            items.Sort();

            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < countElements; i++)
                Assert.AreEqual(items[i], bubble.Items[i]);
        }
    }
}