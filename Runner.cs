using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
   public partial class Runner
    {
        static void Main(string[] args)
        {


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




        }

    }
}
