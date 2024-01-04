using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.generics
{
    public  class Generics
    {

        public static void generics()
        {
            var a = new NamedContainer<int>(42, "The answer");
            var b = new NamedContainer<int>(99, "Number of red balloons");
            var c = new NamedContainer<string>("Programming C#", "Book title");

            Console.WriteLine(a.Item);
            Console.WriteLine(b.Item);
            Console.WriteLine(c.Item);

        }

        public static void lazy_initialisation()
        {
            // Create a Lazy<T> object for deferred initialization
            Lazy<ExpensiveResource> lazyResource = new Lazy<ExpensiveResource>(() => new ExpensiveResource());

            // Access the resource when needed
            ExpensiveResource resource = lazyResource.Value;

            // Use the resource
            resource.DoSomething();
        }


    }

    public class NamedContainer<T>
    {
        public NamedContainer(T item, string name)
        {
            Item = item;
            Name = name;
        }
        public T Item { get; set; }
        public string Name { get; set; }
    }

    public class ExpensiveResource
    {
        public ExpensiveResource()
        {
            // Simulate expensive initialization
            Console.WriteLine("ExpensiveResource is being initialized.");
        }

        public void DoSomething()
        {
            Console.WriteLine("ExpensiveResource is doing something.");
        }
    }


    //refernce constraints
    public class MyClass<T> where T : class
    {
        
    }


    //value type constraints
    public class MyStruct<T> where T : struct
    {
        // T must be a value type (struct)
    }

    public class MyConstructor<T> where T : new()
    {
        // T must have a public parameterless constructor
    }

    public  class SomeBaseClass
    {

    }
    public class MyDerivedClass<T> where T : SomeBaseClass
    {
        // T must derive from SomeBaseClass
    }

    public interface ISomeInterface
    {

    }
    public class MyInterface<T> where T : ISomeInterface
    {
        // T must implement ISomeInterface
    }

    public class CombinedConstraints<T> where T : class, ISomeInterface, new()
    {
        // T must be a reference type, implement ISomeInterface, and have a public parameterless constructor
    }

}

