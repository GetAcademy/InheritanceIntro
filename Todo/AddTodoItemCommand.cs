namespace Todo
{
    internal class AddTodoItemCommand : Command
    {
        public AddTodoItemCommand(TodoList todoList)
        : base(todoList, "1", "Legg til")
        {
        }

        public override void Run()
        {
            Console.WriteLine("Legg til");
            var daysToDeadLine = AskForInt("Hvor mange dager til fristen? ");
            var text = Ask("Hva skal gjøres? ");
            var todoItem = new TodoItem(text, daysToDeadLine);
            _todoList.Add(todoItem);
        }
    }
}
