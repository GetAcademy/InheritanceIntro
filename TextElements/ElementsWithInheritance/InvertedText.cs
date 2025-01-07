namespace TextElements.ElementsWithInheritance
{
    internal class InvertedText : TextElement
    {
        private readonly string _text;

        public InvertedText(string text)
        {
            _text = text;
        }

        public override void Show()
        {
            var foreColor = Console.ForegroundColor;
            var backColor = Console.BackgroundColor;
            Console.ForegroundColor = backColor;
            Console.BackgroundColor = foreColor;
            Console.WriteLine(_text);
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
        }
    }
}
