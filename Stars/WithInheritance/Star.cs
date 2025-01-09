namespace Stars.WithInheritance
{
    internal abstract class Star
    {
        protected int _col;
        private int _row;

        public Star(int col, int row)
        {
            _col = col;
            _row = row;
        }

        public virtual void Update()
        {
        }

        public virtual void Show()
        {
            Console.SetCursorPosition(_col, _row);
        }
    }
}
