using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var classA1 = new ClassA1();
            var classB1 = new ClassB1();
            var classB2 = new ClassB2();


            CallHello(classA1, "A1");
            CallHello(classB1, "B1");
            CallHello(classB2, "B2");
            Console.WriteLine();

            classA1.Hello();
            Console.WriteLine();

            classB1.Hello();
            Console.WriteLine();

            classB2.Hello();
            Console.WriteLine();

            Console.ReadKey();
        }

        static void CallHello(ClassA1 cla, string className)
        {
            Console.WriteLine("Class: " + className);
            var myClass = cla;
            myClass.Hello();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
