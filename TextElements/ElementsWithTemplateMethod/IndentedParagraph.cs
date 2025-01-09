namespace TextElements.ElementsWithTemplateMethod
{
    internal class IndentedParagraph : TextElement
    {
        public IndentedParagraph(string text) : base(text)
        {
        }

        protected override void BeforeShow()
        {
            Console.CursorLeft = 4;
        }
    }
}
