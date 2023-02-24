namespace TelephoneDirectory
{
    public class App
    {
        private List<Directory> directory = new List<Directory>();

        // Runs the app
        public void Run()
        {
            this.directory.AddRange(SeedApp.SeedList);
            int choice = 0;
            do
            {
                Menu.Show();
                choice = Menu.MakeAChoice();
                Console.WriteLine("==============================================");
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...\n");
                        break;
                    case 1:
                        saveNewNumber();
                        break;
                    case 2:
                        deleteNumber();
                        break;
                    case 3:
                        updateNumber();
                        break;
                    case 4:
                        listDirectory();
                        break;
                    case 5:
                        searchNumber();
                        break;
                    default:
                        Console.WriteLine("ERROR: Enter a valid choice!");
                        break;
                }
                this.clearScreen();
            } while(choice != 0);
        }

        // Adds a new record to the list
        public void saveNewNumber()
        {
            string name, surname, number;
            do
            {
                Console.Write("Enter the name: ");
                name = takeInput();
            } while (name.CompareTo("null") == 0);
            do
            {
                Console.Write("Enter the surname: ");
                surname = takeInput();
            } while (surname.CompareTo("null") == 0);
            do
            {
                Console.Write("Enter the number: ");
                number = takeInput();
            } while (number.CompareTo("null") == 0);

            directory.Add(new Directory(name, surname, number));
            Console.WriteLine("Successfuly saved!");
        }

        // Deletes an existing record from the list
        public void deleteNumber()
        {
            while (true)
            {
                string data;
                do
                {
                    Console.Write("Enter the name or surname of the number: ");
                    data = takeInput();
                } while(data.CompareTo("null") == 0);

                foreach (var rec in directory)
                {
                    if (rec.Name.ToLower() == data.ToLower() || rec.Surname.ToLower() == data.ToLower())
                    {
                        Console.WriteLine("A record found!");
                        if (!makeChoice())
                            return;
                        directory.Remove(rec);
                        Console.WriteLine("Successfuly deleted!");
                        return;
                    }
                }
                Console.Write("There is not any record matched with this data. ");
                if (!makeChoice())
                    return;
            }
        }

        // Updates an existing record in the list
        public void updateNumber()
        {
            while (true)
            {
                string data;
                do
                {
                    Console.Write("Enter the name or surname of the number: ");
                    data = takeInput();
                } while(data.CompareTo("null") == 0);

                foreach (var rec in directory)
                {
                    if (rec.Name.ToLower() == data.ToLower() || rec.Surname.ToLower() == data.ToLower())
                    {
                        Console.WriteLine("A record found!");
                        if (!makeChoice())
                            return;
                        Console.Write("Enter the new name: ");
                        rec.Name = takeInput();
                        Console.Write("Enter the new surname: ");
                        rec.Surname = takeInput();
                        Console.Write("Enter the new number: ");
                        rec.Number = takeInput();
                        Console.WriteLine("Successfuly updated!");
                        return;
                    }
                }
                Console.Write("There is not any record matched with this data. ");
                if (!makeChoice())
                    return;
            }
        }

        // Lists all the records in the directory
        public void listDirectory()
        {
            Console.Write("\tDirectory ({0} records)\n----------------------------------------------\n", directory.Count);
            if (directory == null || directory.Count == 0)
            {
                Console.WriteLine("No record!");
                return;
            }
            foreach (var rec in directory)
            {
                Console.WriteLine("\tName\t: " + rec.Name);
                Console.WriteLine("\tSurname\t: " + rec.Surname);
                Console.WriteLine("\tNumber\t: " + rec.Number);
                Console.WriteLine("----------------------------------------------");
            }
        }

        // Searchs the directory for  a name, surname or number
        public void searchNumber()
        {
            while (true)
            {                    
                string choice;
                do
                {
                    Console.Write("\t(1) Search with name/surname\n\t(2) Search with number\n-> ");
                    choice = takeInput();
                } while (choice.CompareTo("null") == 0);
                Console.WriteLine();

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Make a valid choice!\n----------------------------------------------");
                    continue;
                }

                int flag = 0;
                if (choice == "1")
                {
                    Console.Write("Enter a name or surname: ");
                    string data = takeInput();
                    foreach (var rec in directory)
                    {
                        if (rec.Name.ToLower() == data.ToLower() || rec.Surname.ToLower() == data.ToLower())
                        {
                            Console.WriteLine("Name\t: " + rec.Name);
                            Console.WriteLine("Surname\t: " + rec.Surname);
                            Console.WriteLine("Number\t: " + rec.Number);
                            flag = 1;
                        }
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter a number: ");
                    string data = takeInput();
                    foreach (var rec in directory)
                    {
                        if (rec.Number.ToLower() == data.ToLower())
                        {
                            Console.WriteLine("Name\t: " + rec.Name);
                            Console.WriteLine("Surname\t: " + rec.Surname);
                            Console.WriteLine("Number\t: " + rec.Number);
                            flag = 1;
                        }
                    }
                }
                Console.WriteLine("----------------------------------------------");
                if (flag == 0)
                    Console.Write("There is not any record matched with this data! ");
                if (!makeChoice())
                    return;
            }
        }

        public string takeInput()
        {
            string? inp = Console.ReadLine();
            if (inp != null && inp != "")
                return inp;
            Console.WriteLine("Enter a valid entry!\n----------------------------------------------");
            return "null";
        }

        public bool makeChoice()
        {
            while (true)
            {
                Console.Write("Do you want to proceed? (y/n)\n-> ");
                string choice = takeInput();
                if (choice == "y" || choice == "Y")
                    return true;
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("Process canceled...");
                    return false;
                }
                Console.WriteLine("Make a valid choice!");
            }
        }

        // Clears the output screen
        public void clearScreen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public List<Directory> Directory { get { return directory; } }
    }
}