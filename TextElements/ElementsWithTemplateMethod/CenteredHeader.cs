namespace TextElements.ElementsWithTemplateMethod
{
    internal class CenteredHeader : TextElement
    {
        private string _padding;

        public CenteredHeader(string text, char paddingChar) : base(text)
        {
            var startPos = (Console.WindowWidth - _text.Length) / 2;
            var padCount = startPos - 4;
            _padding = "  " + new string(paddingChar, padCount) + "  ";
        }

        protected override void BeforeShow()
        {
            Console.Write(_padding);
        }

        protected override void AfterShow()
        {
            Console.Write(_padding);
        }
    }
}
