namespace ConsumeApi.ViewModel
{
    public class TodoViewModel
    {
        public string Title { get; set; }
        public bool Completed { get; set; }

        public TodoViewModel()
        {
        }
        public TodoViewModel(int id, string title, string description, bool completed, DateTime dueDate)
        {
            Title = title;
            Completed = completed;
        }
    }
}
