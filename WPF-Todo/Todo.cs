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

        string Name { get; set; }

        Priority _priority { get; set; }

        private readonly string thingsTodo;



    }
}
