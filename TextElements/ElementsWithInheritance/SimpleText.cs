namespace TextElements.ElementsWithInheritance
{
    internal class SimpleText : TextElement
    {
        public SimpleText(string text) : base(text)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
    }
}
