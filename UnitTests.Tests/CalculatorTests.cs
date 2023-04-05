using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using UnitTests;

namespace UnitTests.Tests
{
    public class CalculatorTests
    {
        [Fact] 
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            calculator.Miltiplication(2, 4);

            Assert.Equal(8, calculator.Miltiplication(2,4));

            calculator.Subtraction(4, 2);
            Assert.Equal(2, calculator.Subtraction(4,2));


            calculator.Additional(4, 2);
            Assert.Equal(6, calculator.Additional(4, 2));


            calculator.Division(4, 2);
            Assert.Equal(2, calculator.Division(4, 2));

        }
    }
}
