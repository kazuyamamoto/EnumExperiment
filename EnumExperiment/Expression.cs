namespace EnumExperiment
{
    /// <summary>
    /// 式を表す。
    /// </summary>
    public class Expression
    {
        private readonly int _left;
        private readonly int _right;
        private readonly Operator _operator;

        public Expression(int left, int right, Operator op)
        {
            _left = left;
            _right = right;
            _operator = op;
        }

        public int Evaluate()
        {
            return _operator.Operate(_left, _right);
        }
    }
}
