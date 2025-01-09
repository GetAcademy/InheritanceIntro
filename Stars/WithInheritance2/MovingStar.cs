namespace Stars.WithTemplateMethod
{
    internal class MovingStar : Star
    {
        public MovingStar(int col, int row) : base(col, row)
        {
        }

        public override void Update()
        {
            Move();
        }
    }
}
