using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsContain5()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            bool result = Program.IsContain5(arr);
            Assert.AreEqual(true, result);

            int[] arr1 = new int[] { 1, 2, 3, 4, 6 };
            bool result1 = Program.IsContain5(arr1);
            Assert.AreEqual(false, result1);
        }

        [TestMethod]
        public void TestIsContain5Or6()
        {
            int[] arr = new int[] { 1, 2, 3, 5, 6, 8, 7, 9 };
            bool r = Program.IsContain5Or6(arr);
            Assert.AreEqual(true, r);
        }

        [TestMethod]
        public void TestIsContain5And6()
        {
            int[] arr = new int[] { 1, 2, 3, 7, 8 };
            bool r = Program.IsContain5And6(arr);
            Assert.AreEqual(false, r);

            int[] arr1 = new int[] { 1, 2, 3, 5, 6, 7, 8 };
            bool r1 = Program.IsContain5And6(arr1);
            Assert.AreEqual(true, r1);

            int[] arr2 = new int[] { 1, 2, 3, 5, 7, 8 };
            bool r2 = Program.IsContain5And6(arr2);
            Assert.AreEqual(false, r2);

            int[] arr3 = new int[] { 1, 2, 3, 6, 7, 8 };
            bool r3 = Program.IsContain5And6(arr3);
            Assert.AreEqual(false, r3);
        }

        [TestMethod]
        public void TestCout5()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int r = Program.Cout5(arr);
            Assert.AreEqual(0, r);

            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int r1 = Program.Cout5(arr1);
            Assert.AreEqual(1, r1);

            int[] arr2 = new int[] { 1, 2, 5, 6, 5, 5, 5, 5 };
            int r2 = Program.Cout5(arr2);
            Assert.AreEqual(5, r2);
        }

        [TestMethod]
        public void TestSumArr()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5 };
            int r = Program.SumArr(arr);
            Assert.AreEqual(20, r);
        }

        [TestMethod]
        public void TestCout5Or6()
        {
            int[] arr = new int[] { 1, 2, 3, 5, 6, 5 };
            int r = Program.Cout5Or6(arr);
            Assert.AreEqual(3, r);

            int[] arr1 = new int[] { 1, 2, 3, 6, 5 };
            int r1 = Program.Cout5Or6(arr1);
            Assert.AreEqual(2, r1);

            int[] arr2 = new int[] { 1, 2, 3, 3, 4, 7};
            int r2 = Program.Cout5Or6(arr2);
            Assert.AreEqual(0, r2);
        }

        [TestMethod]
        public void TesTCout5And6()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7 };
            int r = Program.Cout5And6(arr);
            Assert.AreEqual(0, r);

            int[] arr1 = new int[] { 1, 2, 3, 5, 6, 4, 7 };
            int r1 = Program.Cout5And6(arr1);
            Assert.AreEqual(1, r1);

            int[] arr2 = new int[] { 1, 2, 3, 5, 6, 6, 4, 7 };
            int r2 = Program.Cout5And6(arr2);
            Assert.AreEqual(2, r2);
        }
    }
}
