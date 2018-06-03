using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types_charastringbooltypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;
            char myVar = 'G';
            int myVarValue = 'G';
            char myVarValue2 = Convert.ToChar(71);
            Console.WriteLine("min value = {0} max value = {1} my character = {2} my variable number = {3}   \nmy convesion value is = {4}", charMin, charMax, myVar, myVarValue, myVarValue2);

            string mystring = "this is my variable";
            Console.WriteLine("\nmy string is {0}", mystring);


            bool mybool = false;
            Console.WriteLine("\nmy boolean value is {0}", mybool);
            Console.ReadKey();
             



        }
    }
}
