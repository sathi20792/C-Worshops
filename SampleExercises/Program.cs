using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // excercise 1
            Console.WriteLine("****************EXERCISE 1************");
            Console.WriteLine("Sathish Manivannan");
            Console.WriteLine("sathishmanivannan20@gmail.com\n");

            // exercise 2
            Console.WriteLine("****************EXERCISE 2************");
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Good Morning " + name+"\n");

            // exercise 3
            Console.WriteLine("****************EXERCISE 3************");
            Console.WriteLine("Please enter a number");
            int num=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The Square of the number is " + num * num+"\n");

            //exercise 4
            Console.WriteLine("****************EXERCISE 4************");
            Console.WriteLine("Please enter a double preision number");
            double dnum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Square of the double precision number is " + dnum * dnum + "\n");

            //exercise 5
            Console.WriteLine("****************EXERCISE 5************");
            Console.WriteLine("Please enter a single precision number");
            double dnum2 = Convert.ToDouble(Console.ReadLine());
            double square = dnum2 * dnum2;
            string number= String.Format("{0:0.00}", square);
            Console.WriteLine("The Square of the single precision number is "+number);
            Console.ReadLine();


        }
    }
}
