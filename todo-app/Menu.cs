namespace ToDo
{
    using System;

    public static class Menu
    {
        // Shows the menu
        public static void Show()
        {
            Console.WriteLine(
            "\n\t\tTO DO\n\n" +
            "\t1. List the board\n" +
            "\t2. Add a card\n" +
            "\t3. Delete a card\n" +
            "\t4. Move a card\n" +
            "\t0. Exit\n");
        }

        // Takes a choice from the user, validates and returns it
        public static int MakeAChoice()
        {
            Console.Write("Make a choice: ");
            string? inp = Console.ReadLine();
            if (inp == null || inp == "")
                return -1;
            for (int i = 0; i < inp.Length; i++)
                if (inp[i] - 48 < 0 || inp[i] - 48 > 9)
                    return -1;
            int choice = Convert.ToInt32(inp);
            if (choice < 0 || choice > 4)
                return -1;
            return choice;
        }
    }
}