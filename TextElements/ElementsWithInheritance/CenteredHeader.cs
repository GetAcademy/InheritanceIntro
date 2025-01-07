namespace TextElements.ElementsWithInheritance
{
    internal class CenteredHeader : TextElement
    {
        private readonly char _paddingChar;

        public CenteredHeader(string text, char paddingChar) : base(text)
        {
            _paddingChar = paddingChar;
        }

        public override void Show()
        {
            var startPos = (Console.WindowWidth - _text.Length) / 2;
            var padCount = startPos - 4;
            var padding = "  " + new string(_paddingChar, padCount) + "  ";
            Console.Write(padding);
            base.Show();
            Console.WriteLine(padding);
        }
    }
}
