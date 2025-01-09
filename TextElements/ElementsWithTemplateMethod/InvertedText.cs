namespace TextElements.ElementsWithTemplateMethod
{
    internal class InvertedText : TextElement
    {
        public InvertedText(string text) : base(text)
        {
        }

        protected override void BeforeShow()
        {
            SwapForeAndBackColor();
        }

        protected override void AfterShow()
        {
            SwapForeAndBackColor();
        }

        private static void SwapForeAndBackColor()
        {
            var foreColor = Console.ForegroundColor;
            var backColor = Console.BackgroundColor;
            Console.ForegroundColor = backColor;
            Console.BackgroundColor = foreColor;
        }
    }
}
