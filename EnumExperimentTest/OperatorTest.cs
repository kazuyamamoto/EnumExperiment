using EnumExperiment;
using NUnit.Framework;

namespace EnumExperimentTest
{
    public class OperatorTest
    {
        [Test]
        public void Add()
        {
            Assert.AreEqual(3, Operator.Add.Operate(1, 2));
        }
    }
}
