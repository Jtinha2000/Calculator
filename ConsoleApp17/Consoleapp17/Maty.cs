using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Maty
    {
        private string Response1; // Creating the variables
        public double Number { get; private set; } // Creating the variables
        public Maty(double number, string response1) // Constructor to pick the values
        {
            Response1 = response1; 
            Number = number;
        }
        public double count()
        {
            if (Response1.Contains("+"))  //It will see if the variable has the +, -, *or / and execute the line of code for the calculation
                           {
                string[] response2 = Response1.Split('+');
                Number = double.Parse(response2[0]) + double.Parse(response2[1]);
            }
            else if (Response1.Contains("-"))
            {
                string[] response2 = Response1.Split('-');
                Number = double.Parse(response2[0]) - double.Parse(response2[1]);
            }
            else if (Response1.Contains("*"))
            {
                string[] response2 = Response1.Split('*');
                Number = double.Parse(response2[0]) * double.Parse(response2[1]);
            }
            else if (Response1.Contains("/"))
            {
                string[] response2 = Response1.Split('/');
                Number = double.Parse(response2[0]) / double.Parse(response2[1]);
            }
            else
            {
                Console.WriteLine("Enter a correct value...");
            }
            return Number;
        }
        public double count1(string Response2) //It will take the value already returned to the user and add to what the user wants
        {
            if (Response2.Contains("+"))
            {
                string[] Response6 = Response2.Split('+');
                Number = Number + double.Parse(Response6[1]);
            }
            else if (Response2.Contains("-"))
            {
                string[] Response6 = Response2.Split('-');
                Number = Number - double.Parse(Response6[1]);
            }
            else if (Response2.Contains("*"))
            {
                string[] Response6 = Response2.Split('*');
                Number = Number * double.Parse(Response6[1]);
            }
            else if (Response2.Contains("/"))
            {
                string[] Response6 = Response2.Split('/');
                Number = Number / double.Parse(Response6[1]);
            }
            else
            {
                Console.WriteLine("Enter a correct value...");
            }
            return Number;
        }
        public override string ToString() // Every time i write... Console.writeline(Maty or a instance) he will write this:
        {
            return "If you need help press: 1\n" + Number + " ";
        }
    }
}
