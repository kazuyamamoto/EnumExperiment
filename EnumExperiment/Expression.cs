namespace EnumExperiment
{
    /// <summary>
    /// 式を表す。
    /// </summary>
    public class Expression
    {
        private readonly Operator _operator;
        private readonly int _left;
        private readonly int _right;

        public Expression(Operator op, int left, int right)
        {
            _operator = op;
            _left = left;
            _right = right;
        }

        public int Evaluate()
        {
            return _operator.Operate(_left, _right);
        }
    }
}
