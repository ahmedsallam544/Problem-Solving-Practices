using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    public partial class Runner
    {

        public static int FirstFactorial(int num)
        {
            /*
             First Factorial
            HIDE QUESTION
            Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it. 
            For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. 
            or the test cases, the range will be between 1 and 18 and the input will always be an integer.
             */
            return (num == 1) ? num : num * FirstFactorial(num - 1);
        }


        public static string TreeConstructor(string[] strArr)
        {
            /*
             Have the function TreeConstructor(strArr) take the array of strings stored in strArr,
             which will contain pairs of integers in the following format: (i1,i2), 
             where i1 represents a child node in a tree and the second integer i2 signifies 
             that it is the parent of i1. For example:
             if strArr is ["(1,2)", "(2,4)", "(7,2)"], then this forms the following tree:
             */
            Dictionary<int, List<int>> keyValues = new Dictionary<int, List<int>>();
            foreach (var Pair in strArr)
            {
                //var Words = Pair.Split(",");
                //var Child = Convert.ToInt32(Words.First().Remove(0, 1));
                //var Parent = Convert.ToInt32(Words.Last().Remove(1));
                //if (keyValues.ContainsKey(Parent))
                //    keyValues[Parent].Add(Child);
                //else
                //    keyValues.Add(Parent, new List<int>() { Child });
            }

            var notValid = keyValues.Any(p => p.Value.Count > 2);
            notValid |= keyValues.Where(h => h.Value.Count > 1).All(i => i.Value.All(t => t > i.Key));
            notValid |= keyValues.Where(h => h.Value.Count > 1).All(i => i.Value.All(t => t < i.Key));
            return notValid ? "false" : "true";
        }
       
       
    }
}
