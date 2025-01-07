namespace TextElements.ElementsWithInterface
{
    internal class IndentedParagraph : ITextElement
    {
        private readonly string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.CursorLeft = 4;
            Console.WriteLine(_text);
        }
    }
}
