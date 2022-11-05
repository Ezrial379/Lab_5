using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{

    internal class Program
    {
        static void Main(string[] args)

        {

            var instance = MyFactory<MyClass>.FacrotyMethod();

            Console.WriteLine(instance.GetType());


            Console.ReadKey();


        }
    }


    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    public class MyClass
    {
        public int Value { get; set; }
        public MyClass(int value)

        {

            Value = value;

        }

        public MyClass() { }
    }

}
