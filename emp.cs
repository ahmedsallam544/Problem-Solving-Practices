using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving_Practices
{
    public class emp
    {
        public int Age { get; set; }
    }

    public class BClass
    {
        public virtual void fun1() {
            Console.WriteLine("BClass fun1");
        }

        public virtual void fun2()
        {
            Console.WriteLine("BClass fun2");
        }

    }
    public class DClass:BClass
    {
        public override void fun1()
        {
            Console.WriteLine("DClass fun1");
        }
        public new void fun2()
        {
            Console.WriteLine("DClass fun2");
        }
    }
   public class Test
    {
        readonly int read = 10;
        const int cons = 10;
        public Test()
        {
            read = 100;
            // cons = 100;  Error compilation error
        }
        public void Check()
        {
            // read = 15; // Constructor or variable initializer 
            System.Console.WriteLine("Read only : {0}", read);
            System.Console.WriteLine("const : {0}", cons);
        }
    }


}
