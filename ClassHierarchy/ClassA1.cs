using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class ClassA1
    {
        public virtual void Hello()
        {
            Console.WriteLine("Hello from class A1");
            this.Hello2();
        }

        public virtual void Hello2()
        {
            Console.WriteLine("Hello 2 from class A1");
        }
    }
}
