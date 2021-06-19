using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    public class MyClass : IDisposable
    {
        public int MyProperty { get; } = 5;
        const string ahmed = "Hello word";
        public MyClass()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    struct MyStruct
    {

    }
    internal struct empp : Interface1
    {
        string name;
        int salary;

        public int MyProperty
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int property
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }


    public interface Interface1
    {
        // int x ;  cannot contain feild

        int MyProperty { get; set; }

        int property { get; set; }


    }
    class creative : Interface1
    {
        //   Stack Over Flow Exception
        // public int MyProperty { get => MyProperty; set { MyProperty = value; } }
        private int myProperty;
        public int MyProperty { get => myProperty; set { myProperty = value; } }
        public int property { get => property; set { property = value; } }

        public void print()
        {
            if (myProperty != 0)
            {
                Console.WriteLine("The property value is " + myProperty);


            }
            else
            {
                Console.WriteLine("No Assignment");
            }
        }
    }
    static class HelperClass
    {
        static public string FirstChar(this string str) // this to extintion method
        {
            return str[0].ToString();
        }
        static public void displayFirst(this Employee emp)
        {

        }
    }
    public class Employee
    {
        int id = 3513551;
        public void displayAll()
        {
            Console.WriteLine(3513);
        }
    }



    class Calculator
    {
        public virtual int MyProperty { get; set; } // virthual property 

        public Calculator()
        {
            Console.WriteLine("I am the constructor");
        }
        ~Calculator()
        {
            Console.WriteLine("I am the Destructor");

        }
        int sum(int x, int y)
        {
            //sealed لازم اكون عملت اوفررايد مرة واحد على الاقل
            return x + y;
        }
        int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        /* public int sum(int x, int y, int z)
         {
             return x + y + z;
             //Error	1	Type 'Inheritence.Calculator' already defines a member called 'sum' with the same parameter types
         } 
         */
        double sum1(int x, int y)
        {
            return x + y;
            //Error	1	Type 'Inheritence.Calculator' already defines a member called 'sum' with the same parameter types
        }

        // GC.suppressFinlize();  to stop finlize ;
    }

    struct ahmed
    {
        public string Ahmed { get; set; }
        public int sallary { get; set; }
    }

    public class BaseClass
    {

        ahmed ahmed = new ahmed(); // struct default public
        Calculator calcul = new Calculator();

        private string A = "Ahmed";
        public virtual string MethodOwnerName()
        {
            return "Base Class";
        }

        public virtual string GetMethodOwnerName()
        {
            return "Base Class";
        }
    }
    public class ChildClass : BaseClass
    {
        // protected int MyProperty { private get; set; }

        public sealed override string MethodOwnerName()
        {
            return "iam child class";
        }
        public new virtual string GetMethodOwnerName()
        {
            return "ChildClass";
        }
    }
}
