using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class ClassB1 : ClassA1
    {
        public override void Hello()
        {
            Console.WriteLine("Hello from class B1");
            this.Hello2();
        }
    }
}
