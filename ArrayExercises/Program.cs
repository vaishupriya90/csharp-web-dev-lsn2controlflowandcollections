using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            //method:1 to do this exercise

            int[] values = { 1, 1, 2, 3, 5, 8 };
            //for (int i = 0; i < values.Length; i++)
            //{
            //    if (values[i] % 2 == 1)
            //    {
            //        Console.WriteLine(values[i]);
            //    }
            //}

            ArrayExercise();
            printOddNum(values);//callind a method from same class..need not mention class name
            ArrayLib.oddNums(values);//calling a method from another class: we should use "className.MethodName"

        }
        //Method:3 or we can do it this way as well

        static void printOddNum(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine(array[i]);
                }
            }


        }
        //method:5 
        class ArrayLib
        {
            public static void oddNums(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

            }
        }
        //Method:2 we can also do it this way 
        static void ArrayExercise()
        {
            int[] values = { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 1)
                {
                    Console.WriteLine(values[i]);
                }
            }

        }
    }
}