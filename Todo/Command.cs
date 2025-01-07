namespace Todo
{
    internal class Command
    {
        protected readonly TodoList _todoList;

        public string Name { get; }
        public string MenuText { get; }

        public Command(TodoList todoList, string name, string menuText)
        {
            _todoList = todoList;
            Name = name;
            MenuText = menuText;
        }

        public virtual void Run()
        {
        }

        private static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        private static int AskForInt(string question)
        {
            var answer = Ask(question);
            return Convert.ToInt32(answer);
        }
    }
}
