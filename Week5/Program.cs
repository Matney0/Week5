using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Print out the options for the user
            Console.WriteLine("1. Add a grade");
            Console.WriteLine("2. Remove a grade");
            Console.WriteLine("3. Display all grades");
            Console.WriteLine("4. Display average for all added grades");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Please make a choice");
            //Reads users choice
            int choice = Convert.ToInt32(Console.ReadLine());


            //Create a list to store the grades
            List<int> grades = new List<int>();
            //Create a switch statement to handle the user's choice
            do
            {
                //Print out the options for the user
                Console.WriteLine("1. Add a grade");
                Console.WriteLine("2. Remove a grade");
                Console.WriteLine("3. Display all grades");
                Console.WriteLine("4. Display average for all added grades");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Please make a choice");

                switch (choice)
                {

                    case 1:
                        //Add a grade
                        Console.WriteLine("Please enter the grade you would like to add: ");
                        int grade = Convert.ToInt32(Console.ReadLine());
                        grades.Add(grade);
                        Console.WriteLine("Want to continue? (Y/N)");
                        string user = Convert.ToString(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Please enter the grade you would like to remove: ");
                        int gradeToRemove = Convert.ToInt32(Console.ReadLine());
                        grades.Remove(gradeToRemove);
                        break;

                    case 3:
                        Console.WriteLine("All grades: ");
                        foreach (int g in grades)
                        {
                            Console.WriteLine(g);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Average grade: ");
                        double average = grades.Average();
                        Console.WriteLine(average);
                        Console.WriteLine("Want to continue? (Y/N)");
                        string user = Convert.ToString(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (user != 'N');
        }
    }
}



        