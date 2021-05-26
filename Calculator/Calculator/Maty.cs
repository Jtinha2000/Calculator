using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Maty
    {
        private string Response1;
        public double Number { get; private set; }
        public Maty(double number, string response1)
        {
            Response1 = response1;
            Number = number;
        }
        public double count()
        {
            if (Response1.Contains("+"))
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
        public double count1(string Response2)
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
        public override string ToString()
        {
            return "If you need help press: 1\n" + Number + " ";
        }
    }
}
