using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    public partial class Runner
    {
        
        public static string ToCamelCase(string str)
        {
            //the-stealth-warrior" ==>  "theStealthWarrior
            var Arr = str.ToCharArray();
            bool isUnderScore = false;
            string NewWord = string.Empty;
            foreach (var letter in Arr)
            {
                if (isUnderScore)
                {
                    NewWord+=letter.ToString().ToUpper();
                    isUnderScore = false;
                    continue;
                }
                if (letter == '-' || letter == '_')
                    isUnderScore = true;
                else
                    NewWord += letter;
            }
            return NewWord;
        }
        //public static string ToCamelCase(string str)
        //{
        //    return string.Concat(str.Split('-', '_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
        //}










    }

}
