namespace TextElements.ElementsWithInheritance
{
    internal abstract class TextElement
    {
        protected string _text;

        protected TextElement(string text)
        {
            _text = text;
        }

        public virtual void Show()
        {
            Console.Write(_text);
        }
    }
}
