namespace FirstAssembly.Test
{
    using MyTestAttr;
    using System;
    using MyCalculator;
    [MyTestClass]
    public class SumTests
    {
        [MyTest]
        public void FirstTest()
        {
            var a = 1;
            var b = 2;

            var result = Calculator.Sum(a, b);
            if (result != 3)
            {
                throw new Exception();
            }
        }
    }
}
