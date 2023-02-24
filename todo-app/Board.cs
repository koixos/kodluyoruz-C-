namespace ToDo
{
    using System;

    public class Board
    {
        private List<Card> toDo = new List<Card>();
        private List<Card> inProgress = new List<Card>();
        private List<Card> done = new List<Card>();

        public Board(List<Card> defaultTasks)
        {
            toDo.AddRange(defaultTasks);
        }

        public Board() {}
        
        // Lists the board
        public void list()
        {
            Console.WriteLine("To Do\n--------------------------------------------");
            print(toDo);
            Console.WriteLine("In Progress\n--------------------------------------------");
            print(inProgress);
            Console.WriteLine("Done\n--------------------------------------------");
            print(done);
        }

        // Prints a given list
        public void print(List<Card> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No task here!");
                return;
            }
            foreach (var task in tasks)
            {
                Console.WriteLine("Title: {0}\n", task.Title);
                Console.WriteLine("Content: {0}\n", task.Content);
                Console.WriteLine("To: {0}\n", task.Id);
                Console.WriteLine("Size: {0}\n", task.Size);
                Console.WriteLine("***");
            }
            Console.WriteLine();
        }

        public List<Card> ToDo
        {
            get { return toDo; }
            set { this.toDo = value; }
        }

        public List<Card> InProgress
        {
            get { return inProgress; }
            set { this.inProgress = value; }
        }

        public List<Card> Done
        {
            get { return done; }
            set { this.done = value; }
        }

    }
}