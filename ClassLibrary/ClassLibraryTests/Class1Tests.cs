using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryNowe01;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNowe01.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void addTwoNumbersTest()
        {
            Class1 obj = new Class1();//MyClass lub Class1Test

            int res = obj.addTwoNumbers(1, 2);
            Assert.IsTrue(res == 3);//-1

            //Assert.Equals(res, 12);
            //Assert.Equals(res, 3);
           
            //Assert.Fail();
        }

        [TestMethod()]
        public void addTwoNumbersTest1()
        {
            Class1 obj = new Class1();//MyClass lub Class1Test

            int res = obj.addTwoNumbers(-1, 2);
            Assert.IsTrue(res == -1);//-1

            //Assert.Equals(res, 12);
            //Assert.Equals(res, 3);

            //Assert.Fail();
        }
    }
}