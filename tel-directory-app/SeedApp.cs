namespace TelephoneDirectory
{
    static class SeedApp
    {
        // Default records
        private static List<Directory> seedList = new List<Directory> {
            new Directory("Zzz", "Ggg", "1111"),
            new Directory("Sss", "Hhh", "2222"),
            new Directory("Bbb", "Yyy", "3333"),
            new Directory("Ttt", "Kkk", "4444"),
            new Directory("Ppp", "Eee", "5555")
        };

        public static List<Directory> SeedList { get { return seedList; } }
    }
}