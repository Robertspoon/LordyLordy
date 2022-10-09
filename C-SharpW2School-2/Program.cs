using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpW2School_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <40)
            Console.WriteLine("Your age: " + age);

            if (age >40)
            Console.WriteLine("Your age: " + age);


            if (age == 40)
            {
                Console.WriteLine("Lordy lordy look who's: " + age);
            }


            


            Console.ReadKey(true);

        }
    }
}
