using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloWorld.types
{
    public class Types
    { 

        public static void  Formating_data_in_Strings()
        {
            string name = "makoha";
            int age = 28;
            string message = $"{name} is {age} years old";

            Console.WriteLine(message);


        }

        public static void Tuples()
        {
            (int x, int y) point = (50, 60);

            Console.WriteLine(point.y);

        }

        public static void Deconstructing_a_tuple() 
        {
            (int x, int y) point = (50, 60);

            (int x, int y) = point;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }



    }
}
