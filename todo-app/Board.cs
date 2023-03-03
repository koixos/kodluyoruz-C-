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
            Console.WriteLine("\tTo Do List\n--------------------------------------------");
            print(toDo);
            Console.WriteLine("\tIn Progress List\n--------------------------------------------");
            print(inProgress);
            Console.WriteLine("\tDone List\n--------------------------------------------");
            print(done);
        }

        public List<Card> selectList()
        {
            while (true)
            {
                Console.WriteLine(" -> Please select a list:\n\n\t1)To Do\n\t2)In Progress\n\t3)Done");
                int choice = Int32.Parse(Card.takeInput("--------------------------------------------\n -> Selection"));
                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Make a valid choice!\n--------------------------------------------");
                    continue;
                }
                if (choice == 1)
                    return toDo;
                if (choice == 2)
                    return inProgress;
                return done;
            }
        }

        public Card searchListByTitle(string title, List<Card> list)
        {
            foreach (var card in list)
                if (card.Title == title)
                    return card;
            return new Card();
        }

        public bool removeCard(string title)
        {
            Card temp = this.searchListByTitle(title, toDo);
            if (temp.Title == "null")
            {
                temp = this.searchListByTitle(title, inProgress);
                if (temp.Title == "null")
                {
                    temp = this.searchListByTitle(title, done);
                    if (temp.Title == "null")
                        return false;
                    done.Remove(temp);
                    return true;
                }
                inProgress.Remove(temp);
                return true;
            }
            toDo.Remove(temp);
            return true;
        }

        public bool updateCard(string title)
        {
            Console.WriteLine("Select where to move the cart:");
            List<Card> _to = this.selectList();
            Card temp = this.searchListByTitle(title, toDo);
            if (temp.Title == "null")
            {
                temp = this.searchListByTitle(title, inProgress);
                if (temp.Title == "null")
                {
                    temp = this.searchListByTitle(title, done);
                    if (temp.Title == "null")
                        return false;
                    done.Remove(temp);
                     _to.Add(temp);
                    return true;
                }
                inProgress.Remove(temp);
                _to.Add(temp);
                return true;
            }
            toDo.Remove(temp);
            _to.Add(temp);
            return true;
        }

        // Prints a given list
        public void print(List<Card> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine(
                " # No task here!\n" +
                "*********************************************");
                return;
            }
            foreach (var task in tasks)
            {
                Console.WriteLine("\tTitle: {0}", task.Title);
                Console.WriteLine("\tContent: {0}", task.Content);
                Console.WriteLine("\tTo: {0}", getKeyByValue(task.Id));
                Console.WriteLine("\tSize: {0}", task.Size);
                Console.WriteLine("*********************************************");
            }
        }

        public string getKeyByValue(int id)
        {
            foreach (var member in SeedTeam.Team)
                if (member.Value == id)
                    return member.Key;
            return "null";
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