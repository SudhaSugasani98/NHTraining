using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary1.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        /// <summary>
        /// This method is used to test if the input is zero
        /// </summary>
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n = 0; 
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// This method is used to test if the input is 1 to 7
        /// </summary>
        [TestMethod()]
        public void FactorialTest_One_to_Seven_Input()
        {
            //Arrange
            int n = 4;
            int expected = 24;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// This method id used to test if the input is >7
        /// </summary>
        [TestMethod()]
        public void FactorialTest_More_Than_Seven_Input()
        {
            //Arrange
            int n = 9;
            int expected = -999;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// This method is used to test if the input is <0
        /// </summary>
        [TestMethod()]
        public void FactorialTest_Less_than_Zero_Input()
        {
            //Arrange
            int n =-7;
            int expected = -9999;
            //Act
            int actual = Algebra.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}