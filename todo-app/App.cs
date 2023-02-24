namespace ToDo
{
    using System;

    public class App
    {
        private Board board = new Board(SeedBoard.Tasks);
        private List<Card> cards = new List<Card>(3);

        // Runs the app
        public void Run()
        {
            int choice = 0;
            do
            {
                Menu.Show();
                choice = Menu.MakeAChoice();
                Console.WriteLine();
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
            } while(choice != 0);        
        }

        public void addCard()
        {
        
        }

        public void deleteCard()
        {

        }

        public void moveCard()
        {
        
        }
    }
}
