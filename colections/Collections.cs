using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.colections
{
    internal class Collections
    {
        public static void creating_array()
        {
            int[] numbers = new int[10];
            Console.WriteLine(numbers);
            Console.WriteLine(numbers[9]);

            String[] workingDays = new string[] { "mon", "Tue", "wed", "thur", "fri" };
            Console.WriteLine(workingDays[0]);
        }

        public static void searching_array_with_index_of()
        {
            String[] workingDays = new string[] { "mon", "Tue", "wed", "thur", "fri" };

            var index = Array.IndexOf(workingDays, "wed");

            var index2 = Array.IndexOf(workingDays, "yuuu");

            Console.WriteLine(index);


            Console.WriteLine(index2);
        }

        public static void searching_array_with_find_index() 
        {
            String[] workingDays = new string[] { "mon", "Tue", "wed", "thur", "fri" };

            bool isLongerThanThree(String value)
            {
                return value.Length > 3;
            }
            var index = Array.FindIndex(workingDays, isLongerThanThree);

            Console.WriteLine(index);
        }


        public static void searching_array_with_find_all() 
        {
            String[] workingDays = new string[] { "mon", "Tue", "wed", "thur", "fri","saturday" };

            bool isLongerThanThree(String value)
            {
                return value.Length > 3;
            }
            string[] result= Array.FindAll(workingDays, isLongerThanThree);

            Console.WriteLine(String.Join(",", result));
        }

        public static void searching_array_with_binary_search() 
        {

            String[] workingDays = new string[] { "mon", "Tue", "wed", "thur", "fri" };

           Array.Sort(workingDays);

            Console.WriteLine(String.Join (",", workingDays));

            var index = Array.BinarySearch(workingDays, "thur");

            Console.WriteLine(index);
        }


        public static void jagged_arrays()
        {
            int[][] ints = new int[5][]
            {
                new[]{1,2,3,8,9 },
                new[]{4,5, },
                new[]{7,8,9,7},
                new[]{10,11,12},
                new[]{11,12,13},
            };

            Console.WriteLine(ints[0][1]);
            Console.WriteLine(ints[1][0]);
        }

        public static void rectangular_arrays() 
        {
            int[,] ints = new int[2, 4]
            {
                {1,2,3,4},
                {2,3,4,5},
            };

            Console.WriteLine(ints[1,1]);
        }

        public static void array_copy_methode() 
        {
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, };
            int[] ints2 = new int[10];
            int[] ints3 = new int[10];
            Array.Copy(ints, ints2, 2);
            //Array.Copy(ints,4, ints3, 0,5);

            Console.WriteLine(String.Join(",",ints2));
            //Console.WriteLine(String.Join(",", ints3));


        }
    }
}
