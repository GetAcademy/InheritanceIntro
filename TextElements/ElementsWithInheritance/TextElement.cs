namespace TextElements.ElementsWithInheritance
{
    internal class TextElement
    {
        protected string _text;

        public TextElement(string text)
        {
            _text = text;
        }

        public virtual void Show()
        {
            Console.Write(_text);
        }
    }
}
