using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {


        public int Id;
        public string Name { get; set; }
        private PriorityList Priority;
        private ProgressList Progress;

        public Task(int id, string name, PriorityList priority = PriorityList.Medium, ProgressList progress = ProgressList.NotStarted)
        {
            Id = id;
            Name = name;
            Priority = priority;
            Progress = progress;
        }

        public enum PriorityList
        {
            Low = 1,
            Medium = 2,
            High = 3
        }
        public enum ProgressList
        {
            NotStarted = 1,
            InProgress = 2,
            Done = 3,
        }
        public void Print()
        {
            Console.WriteLine(($"ID: {Id}; Name: {Name}; Priority: {Priority}; Progress: {Progress}"));
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing task
            List<Task> taskList = new List<Task> { };
            taskList.Add(new Task(1, "Utworzyć ToDoList", Task.PriorityList.Low));
            Console.WriteLine("Witaj w aplikacji TODO List\n");
            Console.WriteLine("Oto lista twoich obecnych zadań:");

            foreach(var task in taskList)
            {
                task.Print();
            }


        }
    }
}