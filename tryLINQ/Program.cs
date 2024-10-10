using Problem_Solving_Practices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 

namespace Problem_Solving_Practices
{
    class DoubleSoze
    {
        Size Size1 = new Size();
        Size Size2 = new Size();
    }
    class Size
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public string MyProperty3 { get; set; }
        public string MyProperty4 { get; set; }
        public DateTime MyProperty5 { get; set; }
        public DateTime MyProperty6 { get; set; }
        public long MyProperty7 { get; set; }
        public double MyProperty8 { get; set; }
        public float MyProperty9 { get; set; }
        public bool MyProperty10 { get; set; }

    }
    class employee
    {
       public static double MinSalary = 3000;

    }
    struct me {

       public int w ; // CaNOt be intialized in structure
      
    }
    interface IAnimal
    {
        void walk();
    }
    class Dog : IAnimal
    {
        public void walk()
        {
            Console.WriteLine("This animal is dog");
        }
    }
    class Wolf : IAnimal
    {
        public void walk()
        {
            Console.WriteLine("This Animal is Wolf ");
        }

    }

    
    internal static class Program
    {



        //private static double MinSalary = 3000;

        static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', ',' }).Length;
        }
        public static string[] RemoveDuplicates(string[] s)
        {    //Remove Duplicated from array 
            HashSet<string> set = new HashSet<string>(s);
            string[] result = new string[set.Count];
            set.CopyTo(result);
            return result;
        }
        enum Numbers
        {
            zero, one, two, three, four, five, six, seven, eight, nine

        }

        static void PrintOddNumbers()
        {
            int[] numbers = new int[]{ 1,21,3,4,5,6,7,8 };

            IEnumerable<int> oddNumbers = from num in numbers where num % 2 != 0 select num;

            foreach (var item in oddNumbers)
            {
                Console.WriteLine("the odd number is : {0}", item);
            }

        }
        static void Main(string[] args)
        {
            PrintOddNumbers();
            Thread.Sleep(1000);

            #region Sequence operation
            string[] compare = new string[] { "Ahmed", "Aml", "Asmaa", "Waffa" };
            string[] compare1 = new string[] { "Eman", "NoYet", "Ibrahim", "Adel" };
            var SequenceEqual =  compare.SequenceEqual(compare1);
            var Ziping = compare.Zip(compare1, (a, b) => a +" => "+b );

            #endregion

            #region Defarred Excution
            int[] number = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int Sequence_operator = 0; //Sequence operator
            var q = from n in number
                    select ++Sequence_operator;
            // Methods like ToList() cause the query to be
            // executed immediately, caching the results.
            //var q = (from n in number
            //         select ++Sequence_operator)
            //         .ToList();

            // The local variable i has already been fully
            // incremented before we iterate the results:
            // Note, the local variable 'i' is not incremented
            // until each element is evaluated (as a side-effect):
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {Sequence_operator}");
            }

            #endregion

            var numbersss = Enumerable.Repeat(Numbers.six, 10);

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var stringsEnums = new List<Numbers> { Numbers.zero, Numbers.one, Numbers.two, Numbers.three ,
            Numbers.four ,Numbers.five ,Numbers.six ,Numbers.seven ,Numbers.eight ,Numbers.nine    };
            var EnumsValidator = new List<Numbers> { Numbers.zero, Numbers.one, Numbers.two, Numbers.three };
            var textNums = from n in numbers
                           select strings[n];
            var NumsEnums = from n in numbers
                           select stringsEnums[n];
            if (NumsEnums.Contains(Numbers.six))
                Console.WriteLine("true");
            var Any = NumsEnums.Any(p => EnumsValidator.Contains(p));
            var All = NumsEnums.All(p => EnumsValidator.Contains(p));

            var digitOddEvens = from n in numbers
                             select new { Digit = strings[n], Even = (n % 2 == 0) };

            //var digitOddEvens = from n in numbers
            //                    select (Digit: strings[n], Even: (n % 2 == 0));


            var before = GC.GetTotalMemory(true);
            Console.WriteLine(before.ToString());
            string[] Qstrings = { "RemoveDuplicates", "ToArray", "RemoveDuplicates", "ToArray", "WriteLine", "WriteLine", "WriteLine" };
            
            var TT = RemoveDuplicates(Qstrings);

            int[] are = { 1, 1, 2, 2 , 3, 3, 4 ,4 , 5 ,6 };
            int[] Q = are.Distinct().ToArray(); //remove Duplicate from array

            foreach (var elem in TT)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(" ===>>>>>>> End of array  <<<<<<<=====");
            Dog dog = new Dog();
            Wolf wolf = new Wolf();
            int ss = 25;
            //MessageBox.Show()
             //i.ToString();  Not Handling Nulls
             //Convert.ToString  Handle Null
           //  is
           Console.WriteLine(dog is Dog);
            //wolf as Dog;
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "ahmed");
            hashtable.Add(2, "ahmed");
            hashtable.Add(3, "ahmed");
            hashtable.Add(4, "ahmed");
            Console.WriteLine(hashtable.ContainsKey(4));
            Console.WriteLine(hashtable.ContainsKey(5));
            Console.WriteLine(hashtable.ContainsValue("ahmed"));

            // createt object in run time 
            var myTestCategory = new { CategoryId = 1, CategoryName = "Category1"};
            Console.WriteLine(employee.MinSalary);
            Console.Write("Memory used = {0}", before - GC.GetTotalMemory(true));

            employee.MinSalary = 5000 ;
            Console.WriteLine(employee.MinSalary);
            int[] ee = new int[5] { 1, 2, 3, 4, 5 };
            Size Sizo = new Size() {  };
            Size Sizo2 = new Size() {  };
            DoubleSoze doubleSoze = new DoubleSoze();
            Console.WriteLine(Utilities.SizeInBytes<Size>(Sizo));
            Console.WriteLine(Utilities.SizeInBytes<DoubleSoze>(doubleSoze));
            Console.WriteLine(Utilities.SizeInBytes<Size>(Sizo2));
            Console.WriteLine( $"{Sizo}={doubleSoze}=={Sizo2}");
            int[] e1 = new int [5] ;
            //e1.CopyTo(ee);
            Console.WriteLine(typeof(Dog));
            Console.WriteLine(typeof(Wolf));
            for (int ii = 0; ii <= 5; ii++)
            {
                if (ii == 4)
                {
                    continue;
                }
                Console.WriteLine("The number is”=" +ii);

            }
            try
            {
                GC.Collect();
            }
            catch (Exception)
            {

                throw;
            }
            for (int i2 = 0; i2 <= 5; i2++)
            {
                if (i2 == 4)
                {
                   // continue;   //ou can 'jump over one iteration' and then resume your loop execution.
                    Console.WriteLine("ana hena ");
                    break; //you can 'jump out of a loop'
                }
                System.Console.WriteLine(" The number is " + i2);

            }
            int x = 111;
            object o = x ; // Boxing
            Console.WriteLine(o + " From Heap");
            int r = (int)o; //UnsafeBoxing  
            Console.WriteLine(r + " From Stack ");
            string s = "Dot Net Tricks Extension Method Example";
            //calling extension method 
            int i = s.WordCount();
            Console.WriteLine(i);
            Console.WriteLine("acasaca");

            // Datasource 
            //Query Expression
            List<int> numberss = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> query =
              from num in numbers
              where num < 10 && num > 3
              select num ;
            // Method invocation
            IEnumerable<int> query1 = numbers.Where(p=> p < 10 && p > 3) ;
            IQueryable<int> Query3 = numbers.Where(p => p > 2 && p < 10).Take(3).AsQueryable();
            Console.WriteLine("IQueryable");
            foreach (var item in Query3)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("IQueryable");

            int query2 = (from num in numbers
                          where num > 3 && num < 9
                          select num).Count();
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(query2);

            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> union = numbers1.Union(numbers2); //1,2,3,4,5,6,7,8,9,10
            IEnumerable<int> join = from e in numbers1
                                    join a in numbers2
                                    on e equals a 
                                    select a & e;
            foreach (var ii in join)
            {
                Console.Write(ii);
            }
            Console.WriteLine("Ana hena");


        }

    
    }
   
}
