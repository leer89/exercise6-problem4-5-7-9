using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6_problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
                Problem 4    

                Create three arrays of type double. Do a compile-time initialization and place
                different values in two of the arrays. Write a program to store the product of the
                two arrays in the third array. Produce a display using the MessageBox class
                that shows the contents of all three arrays using a single line for an element from
                all three arrays. For an added challenge, design your solution so that the two
                original arrays have a different number of elements. Use 1 as the multiplier when
                you produce the third array.
            */

            //int SIZE = 10;
            //double[] array1 = new double[SIZE];
            //double[] array2 = new double[SIZE];
            //double[] array3 = new double[SIZE];

            //array1[0] = 1.4;
            //array2[0] = 10.7;

            //array3[0] = array1[0] * array2[0];
            //Console.WriteLine("Array 1, Element 0: " + array1[0]);
            //Console.WriteLine("Array 2, Element 0: " + array2[0]);
            //Console.WriteLine("The contents of array 3, element 0 is equal to : " + array3[0]);

            /*
                Problem 5
                Write a program that allows the user to enter any number of names, last name
                first. Using one of the predefined methods of the Array class, order the names
                in ascending order. Display the results.
            */

            //Console.WriteLine("How many names do you want to enter?: ");
            //int size = Int32.Parse(Console.ReadLine());

            //string[] names = new string[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Name? : ");
            //    names[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Name - " + (i + 1) + " - " + names[i]);
            //}

            /* 
             * Problem 7
             * Write an application that allows the user to input monthly rainfall amounts for
             * one year. Calculate and display the average rainfall for the year. Display the
             * month name along with the rainfall amount and its variance from the mean.
             */

            //double[] yearlyRainfall = new double[12];
            //double totalRainfall = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine("Enter rainfall for Month " + (i + 1) + ": ");
            //    double rainfall = double.Parse(Console.ReadLine());
            //    yearlyRainfall[i] = rainfall;
            //    totalRainfall += rainfall;
            //}
            //foreach (var item in yearlyRainfall)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("Total Rainfall: " + totalRainfall + " inches for this year.");         

            /*
             * Problem 9
             * Write a program that allows any number of values between 0 and 10 to be
             * entered. When the user stops entering values, display a frequency distribution
             * bar chart. Use asterisks to show the number of times each value was entered. If a
             * given number is not entered, no asterisks should appear on that line. Your
             * application should display error messages if a value outside the acceptable range
             * is entered or if a non-numeric character is entered.   
             */

            bool validInput = false;
            string input;
            int result;
            bool stopInput = false;
            string allInput = "";

            while (!stopInput)
            {
                do
                {
                    validInput = false;
                    Console.WriteLine("Enter a number between 1 or 10 /// Enter Q to Quit");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out result))
                    {
                        if (result > 0 && result < 10)
                        {
                            validInput = true;
                            allInput += input + ",";
                        }
                    }

                    if (input.ToUpper().Equals("Q"))
                    {
                        validInput = true;
                        stopInput = true;
                    }

                    if (!validInput)
                        Console.WriteLine("Invalid output, try again.");
                } while (!validInput);
            }

            string[] numbers = allInput.Split(',');

            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n" + i + "   ");
                for (int c = 0; c < numbers.Length - 1; c++)
                {
                    if (Convert.ToInt32(numbers[c]) == i)
                        Console.Write("*");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
