using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    public partial class Runner
    {
   

        public static List<int> circularPalindromes(string s)
        {
            /*
            * Complete the 'circularPalindromes' function below.
            *
            * The function is expected to return an INTEGER_ARRAY.
            * The function accepts STRING s as parameter.
            */
            List<string> RotateResult = new List<string>() { s };
            for (int i = 0; i < s.Length-1; i++)
            {
                var lastestRotate = RotateResult.LastOrDefault();
                RotateResult.Add(string.Concat(lastestRotate.Substring(1, s.Length - 1), 
                                               lastestRotate.Substring(0, 1)));
            }
            // Check Pslindreomes 
            List<int> Results = new List<int>();
            foreach (var word in RotateResult)
            {
                var AllPalindromesInthisWord = CheckcircularPalindromes(word).Distinct();
                int MaxLengthInLineSubStrings = AllPalindromesInthisWord
                    .Where(str => IsPalindrome(str))
                    .Select(str => str.Length)
                    .Max();
                Results.Add(MaxLengthInLineSubStrings);
            }
            return Results;

        }

        private static List<string> CheckcircularPalindromes(string word )
        {
            List<string> SubstringsInWord = new List<string>();
            if (word.ToCharArray().Length <= 3)
                return new List<string>() { word };
            int lengthOfWord = word.Length -1;
            string SubWordToBeSubString;
            for (int i = 0; i < word.Length; i++)
            {
                SubWordToBeSubString = word.Substring( 0 , lengthOfWord--);
                SubstringsInWord.Add(SubWordToBeSubString);
            }
            lengthOfWord = word.Length - 1;
            for (int i =1 ; i < word.Length  ; i++)
            {
                SubWordToBeSubString = word.Substring( i  , lengthOfWord--);
                SubstringsInWord.Add(SubWordToBeSubString);
            }
            SubstringsInWord.RemoveAll(p => p.Length < 3);
            SubstringsInWord.Distinct();
            var res = SubstringsInWord.Select(p => CheckcircularPalindromes(p)).ToList();
            foreach (var items in res)
            {
                SubstringsInWord.AddRange(items);
            }
            SubstringsInWord.Add(word);
            return SubstringsInWord;
        }
        private static bool IsPalindrome(string word)
        {
            if (word.Length < 3)
                return false;
            int reverseLength = word.Length -1;
            bool isPalindrome = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (i == reverseLength)
                    break;
                else if (word[i] == word[reverseLength])
                    isPalindrome = true;
                else
                    return false;
                reverseLength--;
            }
            return isPalindrome;
        }

        public static string timeConversion(string s)
        {
          /*
           *Complete the 'timeConversion' function below.
           *Sample Input 0    07:05:45PM
           *Sample Output 0   19:05:45
           * The function is expected to return a STRING.
           * The function accepts STRING s as parameter.
           */
            var DateFormated = DateTime.Parse(s);
            return DateFormated.ToString("HH:mm:ss");
        }

        // Lower Performance
        public static int birthdayCakeCandles(List<int> candles)
        { // 2 loops
            var NumberOfHeightCandles = candles.Count(p => p == candles.Max());
            return NumberOfHeightCandles;
        }
        // Best Performance
        public static int birthdayCakeCandless(List<int> candles)
        { // 1 loop
            //Birthday Cake Candles
            // You are in charge of the cake for a child's birthday. 
            //You have decided the cake will have one candle for each year of their total age. 
            //    They will only be able to blow out the tallest of the candles. 
            //    Count how many candles are tallest.
            //Example
            //The maximum height candles are  units high.There are of them, so return .
            int Max = 0;
            int Count = 0;
            foreach (var item in candles)
            {
                if (item == Max)
                    Count++;
                if (item > Max)
                {
                    Max = item;
                    Count = 1;
                }
            }
            return Count;
        }
        public static void miniMaxSum(List<int> arr)
        {
            long min = 0, max = 0, sum = 0;
            min = arr[0];
            max = min;
            sum = min;
            for (int i = 1; i < arr.Count; i++)
            {
                sum += arr[i];
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine((sum - max) + " " + (sum - min));

        }
        public static int solution(int N)
        {
            string result = string.Empty;
            int i = 1;
            bool minus = (N < 0);
            var intList = Math.Abs(N).ToString().Select(digit => int.Parse(digit.ToString()));
            foreach (var num in intList)
            {
                if (num < 5 && i++ == 1)
                {
                    result += "5";
                }
                if (minus && num > 5 && i++ == 1)
                {
                    result += "5";
                }
                result += num.ToString();
            }
            if (minus)
                return -1 * Convert.ToInt32(result);
            else
                return Convert.ToInt32(result);
        }
        public static void staircase(int n)
        {
            // Staircase detail
            //This is a staircase of size :
            //   #
            //  ##
            // ###
            //####
            for (int i = 0; i < n; i++)
            {
                //3 sp + #   => 1 = i
                //2 sp + ##   => 2
                for (int sp = 0; sp < n - (i + 1); sp++)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write("#");
                Console.WriteLine();
            }

        }
        public static int MaxValueWithremove5(int N)
        {
            List<int> Indecies = new List<int>();
            string Number = N.ToString();
            for (int i = 0; i < Number.Length - 1; i++)
            {
                if (Number.ToCharArray()[i] == '5')
                    Indecies.Add(i);
            }
            List<int> Results = new List<int>();
            foreach (var index in Indecies)
            {
                Results.Add(Convert.ToInt32(Number.Remove(index, 1)));
            }

            return Results.Max(p => p);
        }
        //The custom enumerator will return strings that are longer or equal to 3 charaters
        //and shorter or equal 10 characters and start with a capital letter.
        ///^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$ phone expression number
        public static string TreeConstructor(string[] strArr)
        {
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

        public static string palindrome(string S)
        {
            S = S.ToLower();
            StringBuilder sb = new StringBuilder(S);
            bool res = true;
            for (int i = 0; i < S.Length; i++)
            {
                var firstLetter = S[i].ToString() == "?" ? S[S.Length - 1 - i] : S[i];
                var lastletter = S[S.Length - 1 - i].ToString() == "?" ? firstLetter : S[S.Length - 1 - i];
                if (firstLetter != lastletter)
                {
                    res = false;
                    break;
                }
                else if (firstLetter == lastletter && lastletter.ToString() == "?")
                {
                    firstLetter = lastletter = 'a';
                }
                sb[i] = firstLetter;
                sb[S.Length - 1 - i] = lastletter;
            }
            if (!res)
                return "NO";
            else
                return sb.ToString();

        }
        public static int findSubstrings(string str)
        {
            List<string> words = new List<string>();
            List<string> DisMiss = new List<string>();
            StringBuilder sp = new StringBuilder();
            for (int len = 1; len <= str.Length; len++)
            {
                for (int i = 0; i <= str.Length - len; i++)
                {
                    int j = i + len - 1;
                    for (int k = i; k <= j; k++)
                        sp.Append(str[k]);
                    words.Add(sp.ToString());
                    sp = new StringBuilder();
                }
            }
            foreach (var word in words)
            {
                var duplicates = word.ToCharArray().GroupBy(p => p).Where(g => g.Count() > 1).Select(g => g.Key).ToList().Count;
                if (duplicates > 0)
                    DisMiss.Add(word);
            }
            var strDifferences = words.Where(foo => !DisMiss.Contains(foo)).ToList();
            return strDifferences.Count;
        }
        public static List<string> bitPattern(List<int> num)
        {
            StringBuilder LastOccuer = new StringBuilder();
            StringBuilder FirstOccuer = new StringBuilder();
            for (int index = 0; index < num.Count; index++)
            {
                var FirstIdndex = num.IndexOf(num[index]);
                var lastIdndex = num.LastIndexOf(num[index]);
                if (lastIdndex > index)
                {
                    LastOccuer.Append("1");
                }
                else if (lastIdndex == index)
                {
                    LastOccuer.Append("0");
                }
                if (FirstIdndex < index)
                {
                    FirstOccuer.Append("1");
                }
                else if (FirstIdndex == index)
                {
                    FirstOccuer.Append("0");
                }

            }
            return new List<string>() { LastOccuer.ToString(), FirstOccuer.ToString() };
        }

        //public static void change(emp _emp)
        //{
        //    // _emp = new emp() { Age = 22 };  
        //   // _emp.Age = 22;  will change
        //}
        //public static void change(ref emp _emp)
        //{
        //     _emp = new emp() { Age = 22 };  
        //}
        public static emp change(emp _emp)
        {
            _emp = new emp() { Age = 22 };
            return _emp;
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int A = 0;
            int B = 0;
            int i, j;
            i = 0; j = arr.Count - 1;
            while (i < arr.Count)
            {
                A += arr[i][i];
                B += arr[i++][j--];
                //i++;
                //j--;
            }
            return Math.Abs(A - B);
        }
        public static int NumberOfMatches(int n)
        {
            return (n == 1) ? 0
                  : (n % 2 == 0) ? n / 2 + NumberOfMatches(n / 2)
                  : (n - 1) / 2 + NumberOfMatches((n - 1) / 2 + 1);
        }
        public static IList<string> CommonChars(string[] A)
        {
            //Output: ["e", "l", "l"]
            var result = new List<string> { };
            var check = A[0].ToCharArray();
            bool allcontain = true;
            foreach (var item in check)
            {
                foreach (var word in A)
                {
                    //if (word.ToCharArray().Count(p => p == item) == check.Count(p => p == item))
                    //    allcontain = true;
                    //else
                    //{
                    //    allcontain = false;
                    //    continue;
                    //}
                    //if (!Verify(K, Word))
                    //    break;
                }
                if (allcontain)
                    result.Add(item.ToString());
            }
            return result;
        }
        public static bool Verify(string K, string Word)
        {
            foreach (var ch in K.ToCharArray())
            {
                if (Word.Contains(ch))
                {
                    var indexofele = Word.IndexOf(ch);
                    Word = Word.Remove(indexofele, 1);
                }
                else
                    return false;
            }
            return true;
        }
        public static string MinWindowSubstring(string[] strArr)
        {
            var N = strArr[0];
            var K = strArr[1];
            int indexStart = 0, indexEnd = 0;
            for (int i = 0; i < N.Length - 1; i++)
            {
                var Word = N.Substring(i);
                if (!Verify(K, Word))
                    break;
                indexStart = i;
            }
            for (int i = N.Length - 1; i >= 0; i--)
            {
                var Word = N.Substring(indexStart, i - indexStart);
                if (!Verify(K, Word))
                    break;
                indexEnd = i;
            }
            string result = N.Substring(indexStart, indexEnd - indexStart);
            return result;
        }
        public static int NumIdenticalPairs(int[] nums)
        {

            int repeated = 0;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!keyValuePairs.ContainsKey(item))
                    keyValuePairs.Add(item, 1);
                else
                    keyValuePairs[item]++;
            }
            foreach (var item in keyValuePairs.Where(p => p.Value > 1))
            {
                repeated += (item.Value * (item.Value - 1)) / 2;
            }
            return repeated;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j] && i < j)
            //            result++;
            //    }
            //}
            //return result;
        }
        public static string FrequencySort(string s)
        {
            return String.Concat(s.OrderBy(c => c));
            char[] characters = s.ToArray();
            Array.Sort(characters);
            return new string(characters);

        }
        public static int[] RunningSum(int[] nums)
        {
            //Input: nums = [1,2,3,4]
            //Output: [1,3,6,10]
            List<int> strArr = new List<int>();
            foreach (var num in nums)
            {
                if (strArr.Count < 1)
                    strArr.Add(num);
                else
                    strArr.Add(num + strArr.Last());
            }
            return strArr.ToArray();
        }

    }
}
