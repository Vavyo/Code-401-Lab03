using System;

namespace Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 3 numbers: ");
            string userInput = Console.ReadLine();
            string[] splitInput = userInput.Split(' ');
            int[] inputNums = new int[splitInput.Length];

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    inputNums[i] = Convert.ToInt32(splitInput[i]);
                }
                catch (FormatException)
                {
                    inputNums[i] = 1;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Overflow error: {e.Message}");
                }
            }
            Console.WriteLine($"The product of these 3 numbers is: {Product(inputNums)}");

        }
        public static int Product(int[] arr)
        {
            int result = 1;
            if (arr.Length > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    result *= arr[i];
                }
                return result;
            }
            else
            {
                return 0;
            }
        }
        public static int Average()
        {

            return 0;
        }
        public static void Diamond()
        {

        }
        public static int Most(int[] arr)
        {

            return 0;
        }
        public static int Max()
        {

            return 0;
        }
        public static void Save()
        {

        }
        public static void Load()
        {

        }
        public static void Remove()
        {

        }

        public static string[] WordLengths()
        {
            string[] result = new string[0];
            return result;
        }


    }
}
