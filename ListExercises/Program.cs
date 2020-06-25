using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<string> words = new List<string> { "vaishu", "kalai", "kamu", "Diya", "ben", "Aishu" };
            int sum = SumOfEvenNums(numbers);
            Console.WriteLine("The sum of even numbers is: " + sum);    

            SumOfEvenNums(numbers);
            PrintWord(words);





            static int SumOfEvenNums(List<int> nums)
            {
                int sum = 0;
                foreach(int num in nums)
                {
                    if(num % 2 == 0)
                    {
                        sum += num;
                    }
                }


                return sum;
            }

            static void PrintWord(List<string> words)
            {
                string input;
                Console.WriteLine("Enter a number to search the word: ");
                input = Console.ReadLine();
                int inputNum = int.Parse(input);

                for(int i=0;i<words.Count;i++)
                {
                    if(words[i].Length == inputNum)
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }

        }
    }
}
