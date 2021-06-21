using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    public partial class Runner
    {
        public static int CountMatches(List<List<string>> items, string ruleKey, string ruleValue)
        {
            /**
             * Count Items Matching a Rule
            You are given an array items, where each items[i] = [typei, colori, namei] 
            describes the type, color, and name of the ith item. 
            You are also given a rule represented by two strings, ruleKey and ruleValue.
             */
            switch (ruleKey)
            {
                case "type":
                  return  items.Count(p => p[0] == ruleValue) ;
                case "color":
                    return items.Count(p => p[1] == ruleValue)  ;
                case "name":
                    return items.Count(p => p[2] == ruleValue);
                default:
                    return 0 ;
            }
            #region clean code

            //int IndexCol = default ;
            //switch (ruleKey)
            //{
            //    case "type":
            //        IndexCol = 0;
            //        break;
            //    case "color":
            //        IndexCol = 1;
            //        break;
            //    case "name":
            //        IndexCol = 2;
            //        break;
            //    default:
            //        break;
            //}
            //var lst = items.Where(p => p[IndexCol] == ruleValue);
            //return lst.Count();
            #endregion


        }
        public static int Divide(int dividend, int divisor)
        {
            if (dividend >= int.MaxValue || dividend <= int.MinValue)
            {
                var res = (long)dividend / (long)divisor;
                return (int)(res) * -1;
            }
            var result = dividend / divisor;
            return result;
        }
        public static int StrStr(string haystack, string needle)
        {
            /** 
             Implement strStr().
            Return the index of the first occurrence of needle in haystack, 
            or -1 if needle is not part of haystack.
             */
            return (haystack.Contains(needle))? haystack.IndexOf(needle) : -1;

            //if (haystack.Contains(needle))
            //{
            //    return haystack.IndexOf(needle);
            //}
            //return -1;

        }

    }
}
