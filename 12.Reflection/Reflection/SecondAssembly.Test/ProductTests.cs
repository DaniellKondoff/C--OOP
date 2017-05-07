namespace MycalculatorProduct.Tests
{
    using MyCalculator;
    using MyTestAttr;
    using System;

    [MyTestClass]
    public class ProductTests
    {
        [MyTest]
        public void ProductSouldWorkCorrectly()
        {
            var a = 4;
            var b = 20;
            var result = Calculator.Product(a, b);

            if (result != 80)
            {
                throw new Exception($"Expected 80 bur received {result}");
            }
        }
    }
}
