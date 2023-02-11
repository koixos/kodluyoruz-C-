namespace HomeWork
{
    using System;

    public class Hw02_Q2
    {
        const int   SIZE = 20,
                    COUNT = 3;
        static double totalOfAverages = 0;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("HW02 // QUESTION 2\n");
            int[] arrOfNums = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Enter a number: ");
                if ((arrOfNums[i] = inputNumber()) == -1)
                    --i;
            }
            Console.Write("\nNumbers: ");
            print(arrOfNums);

            Array.Sort(arrOfNums);
            int[]   maxThreeNums = new int[COUNT],
                    minThreeNums = new int[COUNT];
            for (int i = 0; i < COUNT; i++)
            {
                minThreeNums[i] = arrOfNums[i];
                maxThreeNums[i] = arrOfNums[SIZE - i - 1];
            }
            Console.Write("\nMax three of array: ");
            print(maxThreeNums);
            Console.WriteLine("Average of the group: " + string.Format("{0:#.##}", calculateAverage(maxThreeNums)) + "\n");
            Console.Write("\nMin three of array: ");
            print(minThreeNums);
            Console.WriteLine("Average of the group: " + string.Format("{0:#.##}", calculateAverage(minThreeNums)) + "\n");
            Console.WriteLine("Total average of two groups: " + totalOfAverages + "\n");
            return;
        }

        public static int inputNumber()
        {
            string? inp = Console.ReadLine();
            if (inp != null && checkValidity(ref inp))
                return Int32.Parse(inp);
            Console.WriteLine("Enter a valid input!");
            return -1; //error
        }

        public static bool checkValidity(ref string inp)
        {
            for (int i = 0; i < inp.Length; i++)
            {
                if (i == 0 && inp[0] == 45)
                    ++i;
                if (inp[i] - 48 < 0 || inp[i] - 48 > 9)
                    return false;
            }
            return true;
        }
        public static double calculateAverage(int[] arr)
        {
            int total = 0;
            foreach (var x in arr)
                total += (int)x;
            double avg = (double)total/arr.Length;
            totalOfAverages += avg;
            return avg;
        }

        public static void print(int[] arr)
        {
            foreach (var x in arr)
                Console.Write(x + " ");
            Console.WriteLine("");
        }
    }
}