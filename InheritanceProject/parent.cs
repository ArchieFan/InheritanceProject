using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class parent
    {

        private protected int x = 0;

        private protected string parentname { get; set; }

        public parent(int i)
        {
            Console.WriteLine($"Class 1 constuctor is called {i}");
        }
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }

        public void Test2()
        {
            Console.WriteLine("Method 2");
        }

    }
}
