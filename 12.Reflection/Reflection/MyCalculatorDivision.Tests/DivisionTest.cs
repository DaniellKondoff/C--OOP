namespace MyCalculatorDivision.Tests
{
    using MyCalculator;
    using MyTestAttr;
    using System;

    [MyTestClass]
    class DivisionTest
    {
        [MyTest]
        public void DevisionShouldWorkCorrectly()
        {
            var a = 10;
            var b = 5;

            var result = Calculator.Divide(a, b);
            if (result != 2)
            {
                throw new Exception($"Expected 2 bur received {result}");
            }
        }

        [MyTest]
        [MyExpectedException(typeof(DivideByZeroException))]
        public void DevisionShouldTrowExceptionWithSecondZeroParameter()
        {
            var a = 10;
            var b = 0;

            Calculator.Divide(a, b);
        }
    }
}
