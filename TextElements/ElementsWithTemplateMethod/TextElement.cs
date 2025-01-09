namespace TextElements.ElementsWithTemplateMethod
{
    internal class TextElement
    {
        protected string _text;

        protected TextElement(string text)
        {
            _text = text;
        }

        public void Show()
        {
            BeforeShow();
            Console.Write(_text);
            AfterShow();
            Console.WriteLine();
        }

        protected virtual void BeforeShow()
        {
        }
        protected virtual void AfterShow()
        {
        }
    }
}
