namespace ToDo
{
    static class SeedBoard
    {
        // Default tasks
        private static List<Card> tasks = new List<Card> {
            new Card("Aaa", "Bbb"),
            new Card("Ccc", "Ddd"),
            new Card("Eee", "Fff")
        };

        public static List<Card> Tasks { get { return tasks; } }
    }
}