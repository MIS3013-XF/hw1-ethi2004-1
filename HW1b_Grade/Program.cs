// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double exam1_weight = .15;
            const double exam2_weight = .25;
            const double exam3_weight = .25;
            const double homework_weight = .2;
            const double participation_weight = .15;

            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            string studentID = Console.ReadLine();

            Console.WriteLine("What was your exam 1 score?");
            double exam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your exam 2 score?");
            double exam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your exam 3 score?");
            double exam3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your homework score?");
            double homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your participation score?");
            double participation = Convert.ToDouble(Console.ReadLine());

            double grade = ((exam1 * exam1_weight) + (exam2 * exam2_weight) + (exam3 * exam3_weight) +
                           (homework * homework_weight) + (participation * participation_weight)) / 100;

            Console.WriteLine(firstname + " " + lastname + " (" + studentID + "), your final grade is: " + grade.ToString("P"));

        }
    }
}
