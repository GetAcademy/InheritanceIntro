namespace Todo
{
    internal class MarkTodoItemAsDoneCommand : Command
    {
        public MarkTodoItemAsDoneCommand(TodoList todoList)
        : base(todoList, "3", "Marker som gjort")
        {
        }

        public override void Run()
        {
            var no = AskForInt("Hvilket nr vil du sette som utført? ");
            var index = no - 1;
            _todoList.MarkAsDone(index);
        }
    }
}
