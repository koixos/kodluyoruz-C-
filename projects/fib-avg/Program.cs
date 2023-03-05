namespace Projects
{
    public class FibonacciAvg
    {
        private static int depth;
        private static int[] arr = new int[0];

        public static void Main()
        {
            Console.Write("Enter the depth: ");
            depth = Int32.Parse(takeInput());
            Array.Resize(ref arr, depth);
            calculate(depth, 1, 1);
            Console.WriteLine("\nAverage of the series : {0:#.##}", calculateAvg(arr));
        }

        // Takes an input from the user returns it
        public static string takeInput()
        {
            string? input = Console.ReadLine();
            return (input == null || input == "") ? "null" : input;
        }

        // Calculate the fibonacci series of a given range
        public static void calculate(int n, int num1, int num2)
        {
            Console.Write("Series: ");
            for (int i = 0; i < n; i+=2)
            {   
                fillArray(i, num1, num2);

                Console.Write(num1 + " ");
                if (i+2 < n)
                    Console.Write(num2 + " ");
                num1 += num2;
                num2 += num1;
            }
        }

        // Fills the array with elements of the series
        public static void fillArray(int i, int a, int b)
        {
            arr[i] = a;
            if (i+1 < depth)
                arr[i+1] = b;
        }

        // Calculates average of an integer array
        public static double calculateAvg(int[] arr)
        {
            double total = 0;
            foreach(var x in arr)
                total += x;
            return total / arr.Length;
        }
    }
}