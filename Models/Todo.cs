namespace TodoCqrs.Models
{
    public class Todo
    {
        public Todo()
        {
            
        }
        public Todo(string Name, bool Done)
        {
            this.Name = Name;
            this.Done = Done;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Done { get; set; }
    }
}