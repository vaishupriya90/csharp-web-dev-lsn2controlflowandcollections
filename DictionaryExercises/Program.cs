using System;
using System.Collections.Generic;
namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            int newId;

            Console.WriteLine("Enter the Students: (or ENTER to finish) ");

            do
            {
                Console.WriteLine("Enter the student Name: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (newStudent != "")
                {
                    Console.WriteLine("Enter the ID for the student: ");
                    input = Console.ReadLine();
                    newId = int.Parse(input);
                    students.Add(newId, newStudent);
                    //Console.ReadLine();
                }

            } while (newStudent != "");

            Console.WriteLine("\nClass Roster: ");

            foreach(KeyValuePair<int,string> student in students)
            {
                
                Console.WriteLine("ID of the student"+ student.Value + " is"+ student.Key );

            }

            

        }
    }
}
