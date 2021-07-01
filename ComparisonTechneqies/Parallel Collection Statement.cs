using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_Solving_Practices;

namespace Problem_Solving_Practices.ComparisonTechneqies
{
    public class Parallel_Collection_Statement
    {
        public delegate void FunctionToCall();
        //public FunctionToCall ForeachDelegate = new FunctionToCall(Foreach);
        //public FunctionToCall ParallelForEachDelegate = new FunctionToCall(ParallelForEach);
        //public FunctionToCall forLoopDelegate = new FunctionToCall(forLoop);

        private static long DoSomeIndependentTimeconsumingTask()
        { 
            //Most Probably some calculation or DB related activity
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }

        public static void Foreach()
        {
            List<int> integerList = Enumerable.Range(1, 10).ToList();

            foreach (int i in integerList)
            {
                long total = DoSomeIndependentTimeconsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            };
        }
        public static void ParallelForEach()
        {
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            Parallel.ForEach(integerList, i =>
            {
                long total = DoSomeIndependentTimeconsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            });
        }
        public static void forLoop()
        {
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            for (int i = 0; i < integerList.Count; i++)
            {
                long total = DoSomeIndependentTimeconsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            }


        }

        public static void Measure(FunctionToCall RunDelegate, string LoopType)
        {
            DateTime StartDateTime = DateTime.Now;
            Console.WriteLine(@"{0} Loop start at : {1}", LoopType, StartDateTime);
            RunDelegate();
            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine(@"{0} Loop end at : {1}", LoopType, EndDateTime);
            TimeSpan span = EndDateTime - StartDateTime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine(@"Time Taken by {0} Loop in miliseconds {1}", LoopType, ms);
            Console.WriteLine("Press any key to exist");
        }
    }
}
