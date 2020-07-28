using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){1,3,5,7,8,9,11,13,14,15};

            IEnumerable<int> largeNumber = numbers.Where(c => c > 14);

            foreach(int i in largeNumber)
            {
                Console.WriteLine("Large Number is " +i);
            }

            IEnumerable<int> results = from num in numbers
                                        where num < 3 || num > 7
                                        orderby num descending
                                        select num;

                    int count         = /*(from num in numbers
                                        where num < 3 || num > 7
                                        orderby num descending
                                        select num).Count();*/

                                        numbers.Where( n => n<3 || n >10).Count();

                Console.WriteLine("Count is " +count);

            foreach(int num in results)
            {
                Console.WriteLine("number is : " +num);
            }

            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char,string>> gQuery = 
                                                                from item in  groupingQuery
                                                                group item by item[0];

            foreach(var item in gQuery)
            {
                //Console.WriteLine("Grouped Items are  - ");
            }
            Student.QueryHighScores(1,90);
            Console.WriteLine("Hello World!");

            MQ app = new MQ();
            int[] nums = {0,1,2,3,4,5,6,7,8,9};

            var q1 = app.QueryMethod1(ref nums);

            foreach(string s in q1)
            {
                Console.WriteLine("string is - " +s);
            }

            IEnumerable<string> mq2;

            app.QueryMethod2(ref nums, out mq2);

            foreach(string s in mq2)
            {
                Console.WriteLine(s);
            }

            Student.GroupBySingleProperty();

        }
    }
}
