using EnumExperiment;
using NUnit.Framework;

namespace EnumExperimentTest
{
    public class ExpressionTest
    {
        [Test]
        public void Evaluate()
        {
            var expression = new Expression(Operator.Add, 1, 2);
            Assert.AreEqual(3, expression.Evaluate());
        }
    }
}
