namespace TelephoneDirectory
{
    using System;

    public static class Menu
    {
        // Shows the menu
        public static void Show()
        {
            Console.WriteLine(
            "\n\t\tDIRECTORY\n\n" +
            "\t1. Save a new number\n" +
            "\t2. Delete an existing number\n" +
            "\t3. Update an existing number\n" +
            "\t4. List directory\n" +
            "\t5. Search in directory\n" +
            "\t0. Exit\n");
        }

        // Takes a choice from the user, validates and returns it
        public static int MakeAChoice()
        {
            Console.Write("\tMake a choice: ");
            string? inp = Console.ReadLine();
            if (inp == null || inp == "")
                return -1;
            for (int i = 0; i < inp.Length; i++)
                if (inp[i] - 48 < 0 || inp[i] - 48 > 9)
                    return -1;
            int choice = Convert.ToInt32(inp);
            if (choice < 0 || choice > 5)
                return -1;
            return choice;
        }
    }
}