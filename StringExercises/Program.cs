using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            char delimeter = 'o';
            sentence = "I Would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse";
            string[] arrayName = sentence.Split(delimeter);
            foreach(string word in arrayName)
            {
                Console.WriteLine(word);

            }
            Console.WriteLine(string.Join(" ", arrayName));


        }
    }
}
