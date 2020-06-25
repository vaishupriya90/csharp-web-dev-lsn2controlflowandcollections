using System;

namespace ArrayGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfStudents = 30;
            string[] students = new string[noOfStudents];
            double[] grades = new double[noOfStudents];
            string input;
            string newStudent;
            int studentCount = 0;

            Console.WriteLine("Enter your Students: (or ENTER to finish)");

            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (newStudent != "")
                {
                    students[studentCount] = newStudent;
                    studentCount++;
                }

            } while (studentCount < 30 && !Equals(newStudent, ""));

            int i = 0;
            foreach(string student in students)
            {
                Console.WriteLine("Enter Grades For " + student + ":");
                input = Console.ReadLine();
                double grade = Double.Parse(input);
                grades[i] = grade;
                i++;
                if(i == studentCount)
                {
                    break;
                }
            }
            Console.WriteLine("\nCalss Roster: ");
            double sum = 0.0;
            for (int j=0; j < studentCount; j++)
            {
                Console.WriteLine(students[j] + " (" + grades[j] + ")");
                sum += grades[j];
            }
            double avg = sum / studentCount;
            Console.WriteLine("Average grade: " + avg);


        }
    }
}
