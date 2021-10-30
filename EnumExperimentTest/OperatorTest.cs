using EnumExperiment;
using NUnit.Framework;

namespace EnumExperimentTest
{
    public class OperatorTest
    {
        [TestCase(Operator.Add, 1, 2, 3)]
        [TestCase(Operator.Subtract, 1, 2, -1)]
        [TestCase(Operator.Multiply, 2, 3, 6)]
        [TestCase(Operator.Divide, 3, 2, 1)]
        public void Run(Operator op, int left, int right, int expected)
        {
            Assert.AreEqual(expected, op.Operate(left, right));
        }
    }
}
