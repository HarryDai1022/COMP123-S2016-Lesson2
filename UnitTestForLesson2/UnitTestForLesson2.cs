﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson2;

namespace UnitTestForLesson2
{
    [TestClass]
    public class UnitTestForLesson2
    {
        [TestMethod]
        public void addXandYTestMethod()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act
            int result = Program.addXandY(x, y);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
