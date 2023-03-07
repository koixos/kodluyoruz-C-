namespace Projects
{
    using System;

    public class DrawTriangle
    {
        public static void Main()
        {
            Console.Write("Enter the size of the triangle: ");
            int size = Int32.Parse(takeInput());
            draw(size);
        }

        public static void draw(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n+i; j++)
                {
                    if (j < n-i-1)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static string takeInput()
        {
            string? inp = Console.ReadLine();
            if (inp == null || inp == "")
                return "null";
            return inp;
        }
    }
}