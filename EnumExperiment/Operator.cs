using System;
using System.Collections;
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

    public static class OperatorExtension
    {
        public static int Operate(this Operator op, int left, int right)
        {
            return Operations[op].Operate(left, right);
        }

        private interface IOperation
        {
            int Operate(int left, int right);
        }

        private class AddOperation : IOperation
        {
            public int Operate(int left, int right)
            {
                return left + right;
            }
        }

        private class SubtractOperation : IOperation
        {
            public int Operate(int left, int right)
            {
                return left - right;
            }
        }

        private class MultiplyOperation : IOperation
        {
            public int Operate(int left, int right)
            {
                return left * right;
            }
        }

        private class DivideOperation : IOperation
        {
            public int Operate(int left, int right)
            {
                return left / right;
            }
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
