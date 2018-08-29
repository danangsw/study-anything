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
            bool show = true;
            while (show) {
                Console.WriteLine("[1] Test logic 1.");
                Console.WriteLine("[2] Test logic 2.");
                Console.WriteLine("[Any Key] Exit.");
                Console.Write("Select test logic? ");

                char key = Char.ToLower(Console.ReadKey().KeyChar);
                if (key.ToString() == "1" || key.ToString() == "2")
                {
                    Console.Clear();
                    int testPattern = 0;
                    int min = 0;
                    int max = 0;
                    switch (key.ToString())
                    {
                        case "1":
                            Console.WriteLine("[1] Test logic 1.");
                            if (validationInputForPattern(out min, out max)) {
                                testPattern = 1;
                            }
                            break;
                        case "2":
                            Console.WriteLine("[2] Test logic 2.");
                            if (validationInputForPattern(out min, out max))
                            {
                                testPattern = 2;
                            }
                            break;
                    }

                    if (testPattern == 1)
                    {
                        Console.WriteLine("Output:");
                        PatternNumber1(min, max);
                    }
                    else if (testPattern == 2)
                    {
                        Console.WriteLine("Output:");
                        PatternNumber2(min, max);
                    }
                }
                else {
                    break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static bool validationInputForPattern(out int min, out int max) {
            min = 0;
            max = 0;
            Console.Write("Input Min: ");
            if (Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.Write("Input Max: ");
                if (Int32.TryParse(Console.ReadLine(), out max))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid number entered.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number entered.");
            }

            return false;
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
                            Console.Write(" ");
                    }
                    oddCount--;
                }
                if (eventCount <= events.Count() && oddCount <= 0)
                {
                    for (int i = 0; i < eventCount; i++)
                    {
                        Console.Write("{0}", events.ToArray()[i]);
                        if (i < eventCount - 1)
                            Console.Write(" ");
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
                        Console.Write(" ");
                }
                isOdd = !isOdd;
                oddCount--;
                Console.WriteLine();
            }
        }
    }
}
