using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Tests
{
    [TestClass()]
    public class TableTests
    {
        [TestMethod]
        public void Power_696969to0_1expected()
        {
            //arrange
            string numberr = "696969";
            string power = "0";
            string expected = "1";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr + "^" + power);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void fewer_100andminus4_0expected()
        {
            //arrange
            string numberr1 = "100";
            string numberr2 = "-4";
            string expected = "0";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr1 + "<" + numberr2);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void greater_10andminus4_1expected()
        {
            //arrange
            string numberr1 = "10";
            string numberr2 = "-4";
            string expected = "1";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr1 + ">" + numberr2);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void equel_5and5_1expected()
        {
            //arrange
            string numberr1 = "5";
            string numberr2 = "5";
            string expected = "1";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr1 + "=" + numberr2);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void max_45to47_47expected()
        {
            //arrange
            string number1 = "45";
            string number2 = "47";
            string expected = "47";

            //act
            Table table = new Table();
            string actual = table.Calculate("max(" + number1 + "," + number2 + ")");

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void div_15to3_5expected()
        {
            //arrange
            string numberr = "15";
            string div = "3";
            string expected = "5";

            //act
            Table table = new Table();
            string actual = table.Calculate(numberr + " div " + div);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}