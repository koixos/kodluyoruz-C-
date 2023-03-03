namespace ToDo
{
    public class Card
    {
        public enum Sizes {XS=1, S, M, L, XL, Null=-1};
        private string? title;
        private string? content;
        private int id;
        private Sizes size;

        public Card(string title="null", string content="null", int id=-1, Sizes size=Sizes.Null)
        {
            this.title = title;
            this.content = content;
            this.id = id;
            this.size = size;
        }
        public Card() {}

        public static Card createCard()
        {
            string title = takeInput("Enter a title");
            string content = takeInput("Enter some details");
            int id = assignMember();
            Sizes size = assignImportance();
            return new Card(title, content, id, size);
        }

        public static int assignMember()
        {
            while (true)
            {
                int id = Int32.Parse(takeInput("Assign to"));
                foreach (var member in SeedTeam.Team)
                    if (id == member.Value)
                        return id;
                Console.WriteLine("No team member found! Try again.");
            }
        }

        public static Sizes assignImportance()
        {
            while (true)
            {
                int size = Int32.Parse(takeInput("Importance (XS = 1, S = 2, M = 3, L = 4 XL = 5)"));
                if (size < 1 || size > 5)
                {
                    Console.WriteLine("Enter a valid importance level!");
                    continue;
                }
                return (Sizes)size;
            }
        }

        public static string takeInput(string infoStr)
        {
            string? inp;
            while (true)
            {
                Console.Write("{0}: ", infoStr);
                inp = Console.ReadLine();
                if (inp == null || inp == "")
                {
                    Console.WriteLine("Enter a valid input!");
                    continue;
                }
                return inp;
            }
        }

        public string Title
        {
            get
            {
                if (this.title == null || this.title == "")
                    return "null";
                return title;
            }
            set { this.title = value; }
        }

        public string Content
        {
            get
            {
                if (this.content == null || this.content == "")
                    return "null";
                return content;
            }
            set { this.content = value; }
        }

        public int Id
        {
            get
            {
                if (this.id < 0)
                    return -1;
                return id;
            }
            set { this.id = value; }
        }

        public Sizes Size
        {
            get { return size; }
            set { this.size = value; }
        }
    }
}