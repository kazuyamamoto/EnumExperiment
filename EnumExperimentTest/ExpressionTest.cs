using EnumExperiment;
using NUnit.Framework;

namespace EnumExperimentTest
{
    public class ExpressionTest
    {
        [Test]
        public void Evaluate()
        {
            var expression = new Expression(1, 2, Operator.Add);
            Assert.AreEqual(3, expression.Evaluate());
        }
    }
}
