using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    public partial class Runner
    {
        static void Main(string[] args)
        {
             circularPalindromes("eededdeedede");
           //print(timeConversion("07:05:45PM"));
           //  Console.WriteLine(birthdayCakeCandless(new List<int>() { 3, 2, 1, 3 }));
           //  Console.WriteLine(birthdayCakeCandles(new List<int>() {4172213,785637,1727934,4057280,2759591,9999907,
           //     7581231,8003508,6238505,1703322,1765333,2002383,713851,8906901,5064552,1953770,2620375,7993420,
           //     3002285,3658299,7900670,6972689,3743150,8941362,3278592,9999907,7986652,6562470,6355117,9999907,
           //     33003,6664223,5228054,9999907,4181388,9453448,8884761,3316855,3201952,6166159,6169138,3527318,
           //     9999907,4837532,6725408,8369052,4672142,2460008,1872708,9076495,8216573,2228721,7301760,7978419,
           //     400057,2154109,564573,3893474,228723,5120661,1656801,4143370,726055,4329026,3380162,7364156,7463192
           //     ,9676068,45878,601273,4830686,6043081,6383858,7344425,727621,7093135,9999907,7762124,8831233,7046282,
           //     2646866,328325,8467788,9999907,5827641,3190416,2472649,9513693,6768187,9999907,7708288,3057664,9324828,
           //     9286142,1361894,7042098,7638592,5004437,9999907,3309099,1102232,3231756,3157189,4719135,2987591,9999907,
           //     677962,5956014,8492294,6259132,1839734,9980012,1931337,3503659,3693851,8583054,9642500,6371656,9999907,9116105,
           //     5293973,9310648,8097135,8084970,7594183,9999907,8924391,6524119,74952
           //}));
           // miniMaxSum(new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 });
           // staircase(4);

            List<List<int>> arr = new List<List<int>>() {
                new List<int>(){ 11, 2, 4 },
                new List<int>(){ 4 ,5 , 6 },
                new List<int>(){ 10, 8, - 12 }
            };
            diagonalDifference(arr);

            emp obj = new emp();
            obj.Age = 30;
            //change(ref obj);
            obj = change(obj);
            Debug.WriteLine(obj.Age);
            Console.WriteLine(obj.Age);

            var bbclas = new BClass();
            bbclas.fun1();//BClass fun1
            bbclas.fun2();//BClass fun2

            var _DClass = new DClass();
            _DClass.fun1();// DClass fun1
            _DClass.fun2();// DClass fun2

            BClass _BClass = new DClass();
            _BClass.fun1();//DClass fun1
            _BClass.fun2();// BClass fun2
            ((DClass)_BClass).fun2();// BClass fun2

            //List<int> NN = new List<int> (){ 1,2,3,1,2 };
            //var resuflt = bitPattern(NN);
            //    //findSubstrings("bcada");

            ////?ab??a
            ////bab??a
            //var ss = palindrome("bab??a");
            //var strAr = new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" };
            //Console.WriteLine(TreeConstructor(strAr));

            //var sy = MaxValueWithremove5(-5000);
            //Console.WriteLine(sy);
            //var collection = new string[] { "Ahm", "adel", "Waffa", "aml" };
            //var config = new EnumeratorConfig
            //{
            //    MinLength = 3,
            //    MaxLength = 10,
            //    StartWithCapitalLetter = true

            //};
            //// The custom enumerator will return strings that are longer than or equal to 3 characters
            //// and shorter than or equal to 10 characters, and start with a capital letter.
            //var enumerator = new CustomStringEnumerator(collection, config);
            //foreach (var s in enumerator)
            //{
            //    Console.WriteLine(s);
            //}

            //var strArr = new string[] { "baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z" };
            /////Output: base,ball
            //var words = strArr[1].Split(",");
            //for (int i = 1; i < strArr[0].Length - 1 ; i++)
            //{
            //    string first = strArr[0].Substring(0, i);
            //    string last = strArr[0].Substring(i , strArr[0].Length - i);
            //    if (words.Contains(first)&& words.Contains(last))
            //        Console.Write(first +","+ last);
            //}
            //var str = "abcababcababcab";

            //    string first = str.Substring(0, str.Length /2);
            //    string last = str.Substring(str.Length / 2);
            //    if (first == last)
            //        Console.WriteLine("yes");
            //    else if(str.Length % 3 == 0)
            //    {
            //    var lastiter = str.Length / 3;
            //    string third = str.Substring(lastiter * 2);
            //    last = str.Substring(lastiter, lastiter );
            //    first = str.Substring( 0 , lastiter );  
            //    if (first == last && last == third)
            //    {
            //        Console.WriteLine("yes");
            //    }
            //    }
            //Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            //var strArr = new string[] { "X:-1", "Y:1", "X:-4", "B:3", "X:5" };
            //StringBuilder spbuilder = new StringBuilder();
            ////Output: B: 3,Y: 1
            //foreach (var item in strArr)
            //{
            //    var keyvalue = item.Split(":");
            //    if (!keyValuePairs.ContainsKey(keyvalue[0]))
            //    {
            //        keyValuePairs.Add(keyvalue[0], Convert.ToInt32(keyvalue[1]));
            //    }
            //    else
            //    {
            //        keyValuePairs[keyvalue[0]] += Convert.ToInt32(keyvalue[1]);
            //    }
            //}
            //foreach (var item in keyValuePairs)
            //{
            //    if (item.Value == 0)
            //        continue;
            //    else
            //    {
            //        if (spbuilder.Length > 1)
            //            spbuilder.Append(",");
            //        spbuilder.Append(string.Format(" {0}: {1}", item.Key, item.Value));
            //    }
            //}

            //var strArr = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };

            //var arr1 = strArr[0].Split(",");
            //var arr2 = strArr[1].Split(",");
            //var result = arr1.Intersect(arr2);
            //StringBuilder ss = new StringBuilder();
            //foreach (var str in result)
            //{
            //    ss.Append(str + ",");
            //}

            //ss.Remove(ss.Length - 1, 1).ToString();
            //var arr = new int[] { 1, 2, 3, 4 };
            //var x = RunningSum(arr);

            //var x = FrequencySort("tree");
            //var intArr = new int[] { 1, 1, 1, 1 };
            //var xx = NumIdenticalPairs(intArr);

            //Output: affhkkse
            //var res = MinWindowSubstring(new string[] { "aaffhkksemckelloe", "fhea" });
            // 3
            //1 4 1
            //3
            //1 1
            //1 2
            //0 2
            var N = new int[] { 1, 4, 1 };
            var Res = new List<int>();
            var Values = new List<int>();
            foreach (var item in N)
            {
                Res.Add((Res.LastOrDefault() == null) ? 0 : Res.LastOrDefault() + item);
            }

            int[,] Q2D = new int[,] { { 1, 1 }, { 1, 2 }, { 0, 2 } };

            for (int col = 0; col < Q2D.GetLength(0); col++)
            {
                int indexend;
                int indexstart = Res[Q2D[col, 1]];
                if (Q2D[col, 0] - 1 < 0)
                    indexend = 0;
                else
                    indexend = Res[Q2D[col, 0] - 1];

                Values.Add(indexstart - indexend);

            }

            bool isplay = false;
            isplay |= true;
            isplay |= false;

            isplay &= false;
            isplay &= true;
            var result = NumberOfMatches(14);



            //var strArr = new string[] { "cool", "lock", "cook" };
            //var x = CommonChars(strArr);

            int x = 111;
            string y = "sdcdas";
            object o = y; // implicit boxing
            System.Console.WriteLine(o);
            string f = (string)o;
            System.Console.WriteLine(f);

            System.Console.WriteLine(o.GetHashCode());
            System.Console.WriteLine(o.ToString());
            System.Console.WriteLine(o.GetType());

            for (int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;   //ou can 'jump over one iteration' and then resume your loop execution.
                    System.Console.WriteLine("ana hena ");
                    break; //you can 'jump out of a loop'
                }
                System.Console.WriteLine(" The number is " + i);
            }
            //Test obj = new Test();
            //obj.Check();
            //   System.Console.WriteLine();


            /// Safe And Unsafe Casting  
            //int x = 10;
            //string y = "ahmed";
            object a = y;
            //  int xx = (int) a;
            string xxx = Convert.ToString(x); // Handles NULL S 
            string b = (string)a.ToString(); // .Tostring Doesnot Handel Null 
            System.Console.WriteLine(a.ToString());
            System.Console.WriteLine(b);
            System.Console.WriteLine(xxx);
            System.Console.WriteLine(Convert.ToString(x) + y);
            int[] array = { 1, 2, 3, 4, 5 };
            // int[] arr = array.Clone();
            // array.CopyTo(arr);

            // int[] arr = { 5, 6, 7, 8, 2, 3, 4, 4 };

            // arr[arr.Length + 1] = 15; IndexOutOfRangeException: 
            string s = "Sherihan";
            //   s.Substring(s.Length + 1);  //Error  System.ArgumentOutOfRangeException

            // arr = null ;
            // arr.ToString();  //System.NullReferenceException
            // Console.WriteLine(9/0); compilation error
            // Enumerator.MoveNext(); 
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //  List<Employee> treeList = new List<Employee>();

            //foreach (Employee item in treeList)
            //{
            //    if (treeList.Count == 0)
            //    {
            //        treeList.Add(item);
            //    }
            //}  //InvalidOperationException

            Interface1 interfaceOperation;
            interfaceOperation = new creative();

            interfaceOperation.MyProperty = 5;
            ((creative)interfaceOperation).print();

            //Console.WriteLine(Program.Argument(null)); //  ArgumentNullException
            // Console.WriteLine(Program.Argument(""));  //   ArgumentException
            // Flow path without exception.
            // Console.WriteLine(Program.A("test"));

            int A = 7, B = 3, SumResult = 55, MulResult;
            //SumMul(A, B, ref SumResult, out MulResult);

            Type Typee = typeof(Calculator);
            Console.WriteLine(Typee);
            // Console.WriteLine(typeof(A)); // Error in compilations

            // printer("ay haga",10);
            // printer(N:5,Pattern:"*");  // no arrangement in parameter
            int ana = new int(); //0 
            int anaa = default; // 0
            int annaa = 0;      // 0

            Console.WriteLine($"{ana } {anaa } { annaa}");

            // Int32 x = 8414;
            // Int64 y = 2445454;
            checked
            {
                // If an overflow happened, it will throw an exception.
                //   x = (Int32)y;
            }
            //string nauul = null;
            //int? nullable; // allow nulls
            //int? y = 500;
            //y = null;
            //int x = 50;
            //if (y.HasValue)
            //{
            //    x = (int)y;

            //}
            //y = x; //safe
            //       //  x = y; //unsafe it needs an explicit casting
            //x = (int)y; //explicit casting
            //string name = "mostafa";

            /*const*/
            Employee emp = new Employee();
            Console.WriteLine(typeof(emp));

            //    Employee emo = default;//= emp; // equality in Refrence
            //  emo.Equals(emp);
            const int pi = 515;
            const string gravity = "Adel Imam";
            // const Employee ffd = emp ; Error must be number or strings
            SortedList sort = new SortedList();

            // sort.Add(2);
            Console.WriteLine($"{pi} { gravity } ");
            //pi = 4654;
            //gravity = "sdaas";


            var d = 15.3; // must have an initial value
            d.GetType();
            dynamic e = 15.3;
            e = emp; // change type defition in runtime 
                     // int[] arr = { 5, 6, 7, 8, 2, 3, 4 };
                     //arr = default;
                     //for (int i = 0; i < arr?.Length; i++) // use (arr?.Length) to get the length only if (arr) is not null
                     //{
                     //    Console.WriteLine(arr[i]);
                     //}


            GC.Collect(0);
            //Old Way
            //  Console.WriteLine(HelperClass.FirstChar(name));
            //  HelperClass.displayFirst(emp);

            //New Way "Extension Method"
            //Console.WriteLine(name.FirstChar());
            //emp.displayFirst();


            //Console.WriteLine(name?.Length ?? -1);
            //StackTrace st = new StackTrace();
            //Console.WriteLine(st.FrameCount);
            //var stackFrames = st.GetFrames();
            //foreach (var frame in stackFrames)
            //{
            //    Console.WriteLine(frame.GetMethod().Name);
            //}







            BaseClass c = new ChildClass();
            ChildClass ss = new ChildClass();

            //Console.WriteLine(c.GetMethodOwnerName());
            // Console.WriteLine(c.MethodOwnerName());
            //Console.WriteLine(s.GetMethodOwnerName());
            //Console.WriteLine(s.MethodOwnerName());
            // Console.WriteLine(s.A); Cannot acess private members of base class
            //Program program = new Program();
            //Console.WriteLine(program.Id);


            //int x;

            //Console.WriteLine("Table of Multiplication ");
            //Console.ReadLine();

            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int k = 1; k <= 12; k++)
            //    {
            //        Console.WriteLine(k + " * " + i + " = " + (i*k));
            //    }

            //    Console.WriteLine("\n" + "/////////////////////////////////////////////");
            //   // Console.ReadLine();

            //}


        }

        public static void print(string WhatUWant)
        {
            Console.WriteLine(WhatUWant);
        }
        public static void print(int WhatUWant)
        {
            Console.WriteLine(WhatUWant);
        }

    }
}
