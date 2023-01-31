namespace console_programming
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello " + name + " " + surname + "!\n");

            DateTime dt = DateTime.Now;
            Console.WriteLine("Date: " + dt + "\n");
        }
    }
}