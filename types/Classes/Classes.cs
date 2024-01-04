using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelloWorld.types.Classes.Bar;

namespace HelloWorld.types.Classes
{
    public class Classes
    {

        public static void using_custom_class()
        {
            var c1 = new Counter();
            var c2 = new Counter();
            Console.WriteLine("c1: " + c1.GetNextValue());
            Console.WriteLine("c1: " + c1.GetNextValue());
            Console.WriteLine("c1: " + c1.GetNextValue());
            Console.WriteLine("c2: " + c2.GetNextValue());
            Console.WriteLine("c1: " + c1.GetNextValue());

        }

        public static void static_members()
        {
            var c1 = new Counter2();
            var c2 = new Counter2();
            c1.GetNextValue();
            c1.GetNextValue();
            c1.GetNextValue();
            c2.GetNextValue();
            Console.WriteLine(c1.Count);
            Console.WriteLine(Counter2.TotalCount);


        }

        public static void copying_references()
        {
            var c1 = new Counter();
            var c2 = c1;
            Console.WriteLine("c1: " + c1.GetNextValue());
            Console.WriteLine("c1: " + c1.GetNextValue());
            Console.WriteLine("c1: " + c1.GetNextValue());
            Console.WriteLine("c2: " + c2.GetNextValue());
            Console.WriteLine("c1: " + c1.GetNextValue());
        }

        public static void comparing_references()
        {
            var c1 = new Counter();
            c1.GetNextValue();
            Counter c2 = c1;
            var c3 = new Counter();
            c3.GetNextValue();
            Console.WriteLine(c1.Count);
            Console.WriteLine(c2.Count);
            Console.WriteLine(c3.Count);
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == c3);
            Console.WriteLine(c2 == c3);
            Console.WriteLine(object.ReferenceEquals(c1, c2));
            Console.WriteLine(object.ReferenceEquals(c1, c3));
            Console.WriteLine(object.ReferenceEquals(c2, c3));
            Console.WriteLine("");
            c2.GetNextValue();
            Console.WriteLine(c1 == c2);
            Console.WriteLine(object.ReferenceEquals(c1, c2));

        }

        public static void comparing_values()
        {
            int c1 = new int();
            c1++;
            int c2 = c1;
            int c3 = new int();
            c3++;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == c3);
            Console.WriteLine(c2 == c3);
            Console.WriteLine(object.ReferenceEquals(c1, c2));
            Console.WriteLine(object.ReferenceEquals(c1, c3));
            Console.WriteLine(object.ReferenceEquals(c2, c3));
            Console.WriteLine(object.ReferenceEquals(c1, c1));
        }

        public static void chaining_constructors()
        {
            var person=new Person("makoha innocent");
            person.Details();
        }


        public static void static_constructors() 
        { 
            var Bar1=new Bar();
            var Bar2 = new Bar();
            var Bar3 = new Bar();
        }

        public static void  out_parameters()
        {
            //out parameter
            int result = Classes.Divide(5, 2, out int r);
            Console.WriteLine($"result: {result} remainder: {r}");

        }

        public static int Divide(int x, int y, out int remainder)
        {
            remainder = x % y;
            return x / y;
        }


        public static void local_varriables()
        {
           Console.WriteLine(AddAndMultiply(4, 5));
        }

        public static int AddAndMultiply(int a, int b)
        {
            int Add()
            {
                return a + b;
            }

            int Multiply(int z)
            {
                return z * 2;
            }

            int sum = Add();
            return Multiply(sum);
        }

        public static void indexer()
        {

            SampleCollection collection = new SampleCollection();
            // Using the indexer to set values
            collection[0] = 10;
            collection[1] = 20;
            collection[2] = 30;

            // Using the indexer to retrieve values
            Console.WriteLine(collection[0]); // Output: 10
            Console.WriteLine(collection[1]); // Output: 20
            Console.WriteLine(collection[2]); // Output: 30
        }


        public static void object_initialiser()
        {
            var person=new Person2{ FirstName = "makoha",LastName="innocent"};
            Console.WriteLine(person.FirstName);
        }

        public static void custom_operators()
        {
            var inno1 = new Inno(1, 2, 3);
            var inno2 = new Inno(2, 3, 4);
            var result = inno1 +inno2;
            Console.WriteLine(result);
        }

        public static void nested_class()
        {
            // Creating an instance of the outer class
            OuterClass outerObject = new OuterClass();

            // Creating an instance of the nested class
            OuterClass.NestedClass nestedObject = new OuterClass.NestedClass();

            // Calling the method of the nested class
            nestedObject.Display();
        }


        public static void implicit_implementation()
        {
            var cat=new Cat();
            cat.makeSound();
        }

        public static void explicit_implementation()
        {
            IAnimal cyborg=new Cyborg();
            cyborg.makeSound();

            IRobot cyborg2 = new Cyborg();
            cyborg2.makeSound();

        }

        public static void anonymus_types()
        {
            var person = new { FirstName = "John", LastName = "Doe", Age = 30 };

            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");

        }

        public static void partial_class()
        {
            Person3 person = new Person3
            {
                FirstName = "John",
                LastName = "Doe"
            };

            person.DisplayFullName();
        }
    }



    // counter class
    public class Counter
    {
        private int _count;

        public int GetNextValue()
        {
            _count += 1;
            return _count;
        }

        public int Count => _count;
    }

    //counter with static members
    public class Counter2
    {
        private int _count;
        private static int _totalCount;
        public int GetNextValue()
        {
            _count += 1;
            _totalCount += 1;
            return _count;
        }
        public static int TotalCount => _totalCount;
        public int Count => _count;
    }
    
    //constructor chaining
    public class Person
    {
        private String _County;
        private String _Name;
        private int _Age;
        public  Person()
        {
            _County = "Busitema";
            
        }

        public Person(String Name):this() {
            this._Name = Name;
        }

        public  void  Details()
        {

            Console.WriteLine(_Name);
            Console.WriteLine(_County);

        }
       
    }

    //static constructors
    public class Bar
    {
        private static DateTime _firstUsed;
        static Bar()
        {
            Console.WriteLine("Bar's static constructor");
            _firstUsed = DateTime.Now;


        }
    }
        public class SampleCollection
        {
            private int[] data = new int[5];

            // Indexer declaration
            public int this[int index]
            {
                get
                {
                    // Getter logic
                    return data[index];
                }
                set
                {
                    // Setter logic
                    data[index] = value;
                }
            }
        }

        public class Person2
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class Inno
        {
            public int A { get; set; }
            public int B { get; set; }  
            public int C { get; set; }

            public Inno(int a, int b, int c)
            {
                A = a;
                B = b;
                C = c;
            }



            // Custom addition operator
            public static Inno operator +(Inno first, Inno second)
            {
                return new Inno(first.A + second.A, first.B + second.B, first.C + second.C);
            }

            // Custom ToString method for better display
            public override string ToString()
            {
                return $"{A} + {B} +{C}";
            }
        }

        public class OuterClass
        {
            // Nested class
            public class NestedClass
            {
                public void Display()
                {
                    Console.WriteLine("Hello from NestedClass!");
                }
            }
        }

        public interface IAnimal
        {
            void makeSound();
        }

        public interface IRobot
        {
            void makeSound();
        }

        public class Cat:IAnimal
        {
            public void makeSound()
            {
                Console.WriteLine("mewwwww!");
            }
        }


        public class Cyborg : IAnimal, IRobot
        {
            void IRobot.makeSound()
            {
                Console.WriteLine("Cringgggggg!");
            }

             void IAnimal.makeSound()
            {
                Console.WriteLine("mewwwww!");
            }
        }

    partial class Person3
    {
        public string FirstName { get; set; }
    }

    partial class Person3
    {
        public string LastName { get; set; }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }









}


