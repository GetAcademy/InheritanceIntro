namespace Stars.WithTemplateMethod
{
    internal class Star
    {
        protected int _col;
        private int _row;
        protected char _char;

        public Star(int col, int row)
        {
            _col = col;
            _row = row;
            _char = '*';
        }

        public virtual void Update()
        {
        }

        public virtual void Show()
        {
            Console.SetCursorPosition(_col, _row);
            Console.Write(_char);
        }

        protected void Move()
        {
            _col = (_col + 1) % Console.WindowWidth;
        }

        protected void Blink()
        {
            _char = _char == '*' ? ' ' : '*';
        }
    }
}
