using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternNumber1(10, 20);
            Console.ReadLine();
            PatternNumber2(1, 7);
            Console.ReadLine();
        }

        /// <summary>
        /// *Input*
        ///    Min: 1
        ///    Max: 10
        ///  *Output*
        ///  3 5 7 9
        ///  3 5 7
        ///  3 5
        ///  3
        ///  2
        ///  2 4
        ///  2 4 6
        ///  2 4 6 8
        ///  2 4 6 8 10
        /// </summary>
        private static void PatternNumber1(int min, int max)
        {
            List<int> odds = new List<int>();
            List<int> events = new List<int>();

            for (int i = min + 1; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
                else
                {
                    events.Add(i);
                }
            }

            int count = odds.Count() + events.Count();
            int oddCount = odds.Count();
            int eventCount = 0;

            while (count > 0)
            {
                if (oddCount > 0)
                {
                    for (int i = 0; i < oddCount; i++)
                    {
                        Console.Write("{0}", odds.ToArray()[i]);
                        if (i < oddCount - 1)
                            Console.Write("_");
                    }
                    oddCount--;
                }
                if (eventCount <= events.Count() && oddCount <= 0)
                {
                    for (int i = 0; i < eventCount; i++)
                    {
                        Console.Write("{0}", events.ToArray()[i]);
                        if (i < eventCount - 1)
                            Console.Write("_");
                    }
                    eventCount++;
                }
                Console.WriteLine();
                count--;
            }
        }

        /// <summary>
        /// Min: 1
        /// Max: 10
        /// 1 3 5 7 9
        /// 2 4 6 8
        /// 1 3 5
        /// 2 4
        /// 1
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private static void PatternNumber2(int min, int max)
        {
            List<int> odds = new List<int>();
            List<int> events = new List<int>();

            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
                else
                {
                    events.Add(i);
                }
            }

            int oddCount = odds.Count();
            bool isOdd = true;
            while (oddCount > 0) {
                for (int i = 0; i < oddCount; i++)
                {
                    if (isOdd) {
                        Console.Write("{0}", odds.ToArray()[i]);
                    }
                    else
                    {
                        Console.Write("{0}", events.ToArray()[i]);
                    }

                    if (i < oddCount - 1)
                        Console.Write("_");
                }
                isOdd = !isOdd;
                oddCount--;
                Console.WriteLine();
            }
        }
    }
}
