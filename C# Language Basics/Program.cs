using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            password();
            printWords();          
        }
        static void printWords()
        {
            Console.Write("Please enter three words: ");
            string input = Console.ReadLine();
            char[] inputSplit = { ' ' };
            string[] inputString = input.Split(inputSplit);

            string first = inputString[0];
            string second = inputString[1];
            string third = inputString[2];

            int firstSecond = String.Compare(first, second, StringComparison.InvariantCulture);
            int firstThird = String.Compare(first, third, StringComparison.InvariantCulture);
            int secondThird = String.Compare(second, third, StringComparison.InvariantCulture);

            if (firstSecond < 0 && firstThird < 0 && secondThird < 0)
            {
                Console.Write($"{first} {second} {third}");
            }
            else if (firstSecond < 0 && firstThird < 0 && secondThird > 0)
            {
                Console.Write($"{first} {third} {second}");
            }
            else if (firstSecond < 0 && firstThird > 0 && secondThird > 0)
            {
                Console.Write($"{third} {first} {second}");
            }
            else if (firstSecond > 0 && firstThird > 0 && secondThird > 0)
            {
                Console.Write($"{third} {second} {first}");
            }
            else if (firstSecond > 0 && firstThird < 0 && secondThird < 0)
            {
                Console.Write($"{second} {first} {third}");
            }
            else
            {
                Console.Write($"{second} {third} {first}");
            }
            Console.WriteLine();
        }
        static void random(string[] characters)
        {           
            Random random = new Random();          
            Console.Write(characters[random.Next(characters.Length)]);          
        }
        static void password()
        {
            string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.Write("Please enter the length of the password: ");
            var length = Console.ReadLine();
            int intID = int.Parse(length.ToString());
            Console.Write("Generated Password: ");
            for (int i = 0; i < intID; ++i)
            {
                random(values);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}