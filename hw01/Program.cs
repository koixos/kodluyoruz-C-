namespace HomeWork
{
    using System;
    public class Hw01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t<-- Task 1 -->\n");
            string? input = null;
            int n = -1;   
            while (n <= 0)
                n = inputPositiveNumber(ref input);
            int[] arrOfNumbers = inputNPositiveNumbers(ref n);
            List<int> listOfNumbers = findEvenOnes(ref arrOfNumbers);
            print(ref listOfNumbers);
            clear(ref arrOfNumbers, ref listOfNumbers);

            Console.WriteLine("\n\t<-- Task 2 -->\n");
            n = -1;
            int m = -1;
            while (n <= 0)
                n = inputPositiveNumber(ref input);
            while (m <= 0)
                m = inputPositiveNumber(ref input);
            arrOfNumbers = inputNPositiveNumbers(ref n);
            listOfNumbers = findDivisibleOnes(ref arrOfNumbers, ref m);
            print(ref listOfNumbers);
            clear(ref arrOfNumbers, ref listOfNumbers);
        
            Console.WriteLine("\n\t<-- Task 3 -->\n");
            n = -1;
            while(n <= 0)
                n = inputPositiveNumber(ref input);
            string[] arrOfWords = inputNWords(ref n);
            Array.Reverse(arrOfWords);
            print(ref arrOfWords);
            clear(ref arrOfWords);

            Console.WriteLine("\n\t<-- Task 4 -->\n");
            string? sentence = "";
            while (string.Compare(sentence,"") == 0)
                sentence = inputSentence();
            howManyWords(ref sentence);
            howManyChars(ref sentence);
            clear();
            return; // end
        }
        
        // Asks user to give n positive numbers
        public static int[] inputNPositiveNumbers(ref int n)
        {
            int[] arr = new int[n];
            string? inp = null;
            for (int i = 0; i < n; i++)
                if ((arr[i] = inputPositiveNumber(ref inp)) == -1)
                    --i;
            return arr;
        }

        // Takes a null string and asks user to input a positive number
        // If the given number validated, returns it; if not returns -1 (as error) 
        public static int inputPositiveNumber(ref string? inp)
        {
            Console.Write("Please enter a positive number: ");
            inp = Console.ReadLine();
            if (inp != null && checkValidity(ref inp))
                return Int32.Parse(inp);
            Console.WriteLine("Enter a valid input!");
            return -1;
        }

        // Takes n words from the user
        public static string[] inputNWords(ref int n)
        {
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
                if (string.Compare((arr[i] = inputWord()),"") == 0)
                    --i;
            return arr;
        }

        // Takes a sentence from the user
        public static string inputSentence()
        {
            Console.Write("Please enter a sentence: ");
            string? inp = Console.ReadLine();
            if (inp != null)
                return inp;
            Console.WriteLine("Enter a valid sentence!");
            return "";
        }

        // Takes a word from the user
        // If input is null, returns "null" as an error indicator
        public static string inputWord()
        {
            Console.Write("Please enter a word: ");
            string? inp = Console.ReadLine();
            if (inp != null && checkValidity(ref inp, "ignoreMe"))
                return inp;
            Console.WriteLine("Enter a valid word!");
            return "";
        }

        // Checks the input whether it is a positive number or not 
        public static bool checkValidity(ref string inp)
        {
            for (int i = 0; i < inp.Length; i++)
                if ((int)inp[i]-48 <= 0 || (int)inp[i]-48 > 9)
                    return false;
            return true;
        }

        // Checks the input whether it is a word or a sentence
        public static bool checkValidity(ref string inp, string ignoreMe="")
        {
            return !inp.Contains(' ');
        }

        // Takes an array of integers and finds even numbers in it
        public static List<int> findEvenOnes(ref int[] arr)
        {
            List<int> evenOnes = new List<int>();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    evenOnes.Add(arr[i]);
            return evenOnes;
        }

        // Takes an array of integers and an integer divisor to find divisible numbers in the array 
        public static List<int> findDivisibleOnes(ref int[] arr, ref int divisor)
        {
            List<int> divisibleOnes = new List<int>();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % divisor == 0)
                    divisibleOnes.Add(arr[i]);
            return divisibleOnes;
        }

        // Takes a sentence and calculates how many words in it
        public static void howManyWords(ref string inp)
        {
            string[] arr = inp.Split(' ');
            Console.WriteLine("Number of words: " + arr.Length);
        }

        // Takes a sentence and calculates how many characters it has
        // Note: White spaces ignored
        public static void howManyChars(ref string inp)
        {
            int count = 0;
            string[] arr = inp.Split(' ');
            for (int i = 0; i < arr.Length; i++)
                count += arr[i].Count<char>();
            Console.WriteLine("Number of chars: " + count);
        }

        // Prints a given integer list
        public static void print(ref List<int> list)
        {
            foreach (var x in list)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        // Prints a given array of strings
        public static void print(ref string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine();
        }

        // Clears the console and the given variables for the following task
        public static void clear(ref int[] arr, ref List<int> list)
        {
            Console.WriteLine("Press a key to continue...");
            Console.ReadLine();
            Array.Clear(arr);
            list.Clear();
            Console.Clear();
        }

        // Clears the console and the given variable for the following task
        public static void clear(ref string[] arr)
        {
            Console.WriteLine("Press a key to continue...");
            Console.ReadLine();
            Array.Clear(arr);
            Console.Clear();
        }

        // clear method with no paramater
        public static void clear()
        {
            string[] arr = {""};
            clear(ref arr);
        }
    }
}