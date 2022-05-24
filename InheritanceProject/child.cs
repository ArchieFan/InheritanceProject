using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class child : parent
    {
        child() : base(10000)
        {

            Console.WriteLine("Class 2 constuctor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            child c = new child();
            c.x = 100;
            c.parentname = "Parent name";
            c.Test1();
            c.Test2();
            c.Test3();
            parent c1 = new parent(5);
            c1.Test1();
            c1.Test2();
            parent p; //p is variable of class 1
            child c2 = new child();
            p = c2; //p is reference of parent class created by child
            p.Test1();
            p.Test2();
            
            Object obj= new Object();
            Console.WriteLine(obj.GetType());
            parent par = new parent (4);
            Console.WriteLine(par.GetType());
            child chi = new child ();
            Console.WriteLine(chi.GetType());
            Console.ReadLine();
        }
    }
}
