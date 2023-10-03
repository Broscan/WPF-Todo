namespace WPF_Todo
{
    public enum Priority
    {
        Critical,
        High,
        Medium,
        Low
    }
    internal class Todo
    {
        private readonly string chore;

        public Todo(string chore)
        {
            this.chore = chore;

        }

        Priority _priority { get; set; }

        public string GetChores()
        {
            return $"Chore: {chore} - Priority: {_priority} ";

        }
    }

}
