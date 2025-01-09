namespace Stars.WithTemplateMethod
{
    internal class BlinkingStar : Star
    {
        public BlinkingStar(int col, int row) : base(col, row)
        {
        }

        public override void Update()
        {
            Blink();
        }
    }
}
