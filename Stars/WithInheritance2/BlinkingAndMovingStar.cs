namespace Stars.WithTemplateMethod
{
    internal class BlinkingAndMovingStar : Star
    {
        public BlinkingAndMovingStar(int col, int row) : base(col, row)
        {
        }

        public override void Update()
        {
            Blink();
            Move();
        }
    }
}
