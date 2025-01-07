using Todo;

var todoList = new TodoList();
var commands = new Command[]
{
    new AddTodoItemCommand(todoList), 
    new DeleteTodoItemCommand(todoList), 
    new MarkTodoItemAsDoneCommand(todoList)
};

while (true)
{
    Console.Clear();
    Console.WriteLine("Todo:");
    Console.WriteLine(todoList.ListAsText());
    Console.WriteLine("Kommandoer");
    foreach (var command in commands)
    {
        Console.WriteLine($"{command.Name} - {command.MenuText}");
    }

    var cmd = Console.ReadLine();

    foreach (var command in commands)
    {
        if (command.Name == cmd)
        {
            command.Run();
            break;
        }
    }
}