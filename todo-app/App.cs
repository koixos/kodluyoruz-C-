namespace ToDo
{
    using System;

    public class App
    {
        private Board board = new Board(SeedBoard.Tasks);

        // Runs the app
        public void Run()
        {
            int choice = 0;
            do
            {
                Menu.Show();
                choice = Menu.MakeAChoice();
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...\n");
                        break;
                    case 1:
                        this.board.list();
                        break;
                    case 2:
                        this.addCard();
                        break;
                    case 3:
                        this.deleteCard();
                        break;
                    case 4:
                        this.moveCard();
                        break;
                    default:
                        Console.WriteLine("ERROR: Enter a valid choice!");
                        break;
                }
                this.clear();
            } while(choice != 0);        
        }

        public void addCard()
        {
            this.board.selectList().Add(Card.createCard());
        }

        public void deleteCard()
        {
            while (true)
            {
                string title = Card.takeInput("Enter the title");
                if (this.board.removeCard(title))
                {
                    Console.WriteLine("Succesfully deleted!\n--------------------------------------------");
                    return;
                }
                Console.WriteLine("No card found matched with this title!\n--------------------------------------------");
                if (!makeAChoice())
                    return;
            }
        }

        public void moveCard()
        {
            while (true)
            {
                string title = Card.takeInput("Enter the title");
                if (this.board.updateCard(title))
                {
                    Console.WriteLine("Succesfully updated!");
                    return;
                }
                Console.WriteLine("No card found matched with this title!");
                if (!makeAChoice())
                    return;
            }
        }

        public bool makeAChoice()
        {
            while (true)
            {
                Console.Write("Make a choice to continue:\n\t1) Cancel\n\t2) Try again\n\n");
                int choice = Int32.Parse(Card.takeInput("Choice"));
                if (choice == 1)
                    return false;
                else if (choice == 2)
                    return true;
                Console.WriteLine("Make a valid choice!");
            }
        }

        public void clear()
        {
            Console.Write("Type any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
