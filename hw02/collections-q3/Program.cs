namespace HomeWork
{
    using System;

    public class Hw02_Q3
    {
        public static void Main(string[] args)
        {
            string? inp = null;
            while (!takeSentence(ref inp));
            char[] vowels = new char[1];
            findVowels(ref inp, ref vowels);
            Console.Write("\nVowels in the string: ");
            print(vowels);
        }

        public static bool takeSentence(ref string? inp)
        {
            Console.Write("Enter a sentence: ");
            inp = Console.ReadLine();
            if (inp == null || inp.CompareTo("") != 1)
            {
                Console.WriteLine("NULL INPUT!");
                return false;
            }
            return true;
        }

        public static void findVowels(ref string inp, ref char[] arr)
        {
            char[] vowels = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            int count = 0;
            string temp = inp.ToLower();
            for (int i = 0; i < temp.Length; i++)
            {
                if (vowels.Contains(temp[i]))
                {
                    arr[i-count] = temp[i];
                    Array.Resize(ref arr, arr.Length+1);
                }
                else
                    ++count;
            }
        }

        public static void print<T>(T[] arr)
        {
            foreach (var x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }     
}