namespace HomeWork
{
    using System;
    using System.Collections;

    public class Hw02_Q1
    {
        const int SIZE = 20;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("HW02 // QUESTION 1\n");
            int[] arrOfNums = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Enter a positive number: ");
                if ((arrOfNums[i] = inputPositiveNumber()) == -1)
                    --i;
            }
            Console.Write("\nNumbers: ");
            print(arrOfNums);
            ArrayList   primeList = new ArrayList(),
                        notPrimeList = new ArrayList();
            foreach (int num in arrOfNums)
            {
                if (isPrime(num))
                    primeList.Add(num);
                else
                    notPrimeList.Add(num);
            }
            Console.Write("Primes: ");
            print(primeList);
            Console.Write("Not Primes: ");
            print(notPrimeList);
            return;
        }

        public static int inputPositiveNumber()
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
                if (inp[i] - 48 < 0 || inp[i] - 48 > 9)
                    return false;
            return true;
        }

        public static bool isPrime(int inp)
        {
            if (inp == 2)
                return true;
            for (int i = 2; i < inp; i++)
                if (inp % i == 0)
                    return  false;
            return true;
        }

        public static double calculateAverage(ArrayList arrList)
        {
            int total = 0;
            foreach (var x in arrList)
                total += (int)x;
            return (double)total/arrList.Count;
        }

        public static void print(ArrayList arrList)
        {
            arrList.Sort();
            foreach (var x in arrList)
                Console.Write(x + " ");
            Console.WriteLine(string.Format(
                "\nNumber of elements: {0}\nAverage of the group: {1:0.00}\n", arrList.Count, calculateAverage(arrList)
            ));
        }

        public static void print<T>(T[] arr)
        {
            foreach (var x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}