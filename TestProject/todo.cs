public class Todo
{
    public Todo()
    {
        TodoList = new List<Todo>();
    }
    public List<Todo> TodoList;
    public string UserName {get; set;}
}