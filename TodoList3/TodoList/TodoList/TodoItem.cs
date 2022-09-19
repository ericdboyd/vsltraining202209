namespace TodoList
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public bool Completed { get; set; }

        public TodoItem()
        {

        }

        public TodoItem(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        public TodoItem(Guid id, string title, bool completed)
        {
            Id = id;
            Title = title;
            Completed = completed;
        }
    }
}