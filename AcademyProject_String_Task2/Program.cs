using System;

namespace AcademyProject_String_Task2
{
    internal class Program
    {
        static int IsAlphabetic(char c)
        {
            if (c <= 'z' && c >= 'a')
            {
                return 1;
            }

            else if (c <= 'Z' && c >= 'A')
            {
                return -1;
            }

            else return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a phrase: ");
            string phrase = Console.ReadLine();

            int vowelCount = 0, consonantCount = 0;

            foreach (char c in phrase)
            {
                if (IsAlphabetic(c) == 0) continue;

                char upChar = char.Parse(c.ToString().ToUpper());
                Console.WriteLine(upChar);

                if (upChar == 'A' ||
                    upChar  == 'E' ||
                    upChar == 'I' ||
                    upChar == 'O' ||
                    upChar == 'U') { vowelCount++; }

                else consonantCount++;
            }

            Console.WriteLine("Vowels: " + vowelCount);
            Console.WriteLine("Consonants: " + consonantCount);
        }
    }
}
