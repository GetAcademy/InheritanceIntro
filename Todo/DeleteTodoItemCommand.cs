namespace Todo
{
    internal class DeleteTodoItemCommand : Command
    {
        public DeleteTodoItemCommand(TodoList todoList)
        : base(todoList, "2", "Slett")
        {
        }

        public override void Run()
        {
            var no = AskForInt("Hvilket nr vil du slette? ");
            var index = no - 1;
            _todoList.Delete(index);
        }
    }
}
