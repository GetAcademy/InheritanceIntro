namespace TextElements.ElementsWithTemplateMethod
{
    internal class BulletPoint : TextElement
    {
        public BulletPoint(string text) : base(text)
        {
        }

        protected override void BeforeShow()
        {
            Console.Write(" * ");
        }
    }
}
