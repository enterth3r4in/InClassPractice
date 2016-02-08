using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Cody Miller
 * Purpose: To determine grade for 2 students
 * Input: Takes in 2 names and 2 ints
 * Output: Should display conditionally based on grade input
 * Variables: ints for grades, strings for names
 * Main algorithm: Checks input and using if/else statements determines output
 * Testing: entering a name and a 85 on both should result in the display "Name got a B!"
 * February 8, 2016
 **/

namespace InClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGrade, secondGrade;
            string firstName, secondName;

            Console.Write("Enter a name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter their grade [0-100]: ");
            firstGrade = int.Parse(Console.ReadLine());

            Console.Write("Enter another name: ");
            secondName = Console.ReadLine();
            Console.Write("Enter their grade [0-100]: ");
            secondGrade = int.Parse(Console.ReadLine());

            if (firstGrade >= 90)
                Console.WriteLine(firstName + " got an A!");
            else if (firstGrade >= 80)
                Console.WriteLine(firstName + " got a B!");
            else if (firstGrade >= 70)
                Console.WriteLine(firstName + " got a C!");
            else if (firstGrade >= 60)
                Console.WriteLine(firstName + " got a D!");
            else
                Console.WriteLine(firstName + " failed the class!");

            if (secondGrade >= 90)
                Console.WriteLine(secondName + " got an A!");
            else if (secondGrade >= 80)
                Console.WriteLine(secondName + " got a B!");
            else if (secondGrade >= 70)
                Console.WriteLine(secondName + " got a C!");
            else if (secondGrade >= 60)
                Console.WriteLine(secondName + " got a D!");
            else
                Console.WriteLine(secondName + " failed the class!");
        }
    }
}
