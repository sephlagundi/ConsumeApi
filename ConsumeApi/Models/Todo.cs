namespace ConsumeApi.Models
{
    public class Todo
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public Todo() { }


        public Todo(int id, string title, string description, bool completed, DateTime dueDate)
        {
            Id = id;
            Title = title;
            Completed = completed;
        }
    }
}
