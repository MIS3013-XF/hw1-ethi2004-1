// HW1a Sales Total

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SALES_TAX = 0.085;
            Console.WriteLine("What are you purchasing?");
            string product = Console.ReadLine();

            Console.WriteLine("How many " + product + " do you want?");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price of one " + product);
            double price = Convert.ToDouble(Console.ReadLine());


            double subtotal = (quantity * price);

            double salestax = (subtotal * SALES_TAX);

            double total = (subtotal + salestax);

            Console.WriteLine("Your subtotal is: " + subtotal.ToString("N2"));
            Console.WriteLine("The amount of sales tax is: " + salestax.ToString("N2"));
            Console.WriteLine("The total cost is: " + total.ToString("N2"));
        }
    }
}
