using System.Collections.Generic;

namespace EnumExperiment
{
    /// <summary>
    /// 演算子を表す。
    /// </summary>
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    /// <summary>
    /// <see cref="Operator"/> に振る舞いを提供する拡張クラス。
    /// </summary>
    public static class OperatorOperation
    {
        /// <summary>
        /// 演算を行う。
        /// </summary>
        /// <param name="op">演算子</param>
        /// <param name="left">左辺</param>
        /// <param name="right">右辺</param>
        /// <returns>演算結果</returns>
        public static int Operate(this Operator op, int left, int right) => Operations[op].Operate(left, right);

        private interface IOperation
        {
            int Operate(int left, int right);
        }

        private class AddOperation : IOperation
        {
            public int Operate(int left, int right) => left + right;
        }

        private class SubtractOperation : IOperation
        {
            public int Operate(int left, int right) => left - right;
        }

        private class MultiplyOperation : IOperation
        {
            public int Operate(int left, int right) => left * right;
        }

        private class DivideOperation : IOperation
        {
            public int Operate(int left, int right) => left / right;
        }

        private static readonly IDictionary<Operator, IOperation> Operations = new Dictionary<Operator, IOperation>
        {
            { Operator.Add, new AddOperation() },
            { Operator.Subtract, new SubtractOperation() },
            { Operator.Multiply, new MultiplyOperation() },
            { Operator.Divide, new DivideOperation() }
        };
    }
}
