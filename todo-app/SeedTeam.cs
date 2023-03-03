namespace ToDo
{
    static class SeedTeam
    {
        // Default team
        private static Dictionary<String,Int32> team = new Dictionary<string, int> {
            {"Zzz", 1},
            {"Ttt", 54},
            {"Ddd", 2},
            {"Aaa", 666},
            {"Jjj", 3}
        };

        public static Dictionary<String,Int32> Team { get { return team; } }
    }
}