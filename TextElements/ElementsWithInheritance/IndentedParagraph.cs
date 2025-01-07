namespace TextElements.ElementsWithInheritance
{
    internal class IndentedParagraph : TextElement
    {
        private readonly string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public override void Show()
        {
            Console.CursorLeft = 4;
            Console.WriteLine(_text);
        }
    }
}
