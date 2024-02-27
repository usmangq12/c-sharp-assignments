/* Assignment:
 * Given a number n, for each integer i in the range from 1 to n inclusive, print one value per line as follows:
• If i is a multiple of both 3 and 5, print FizzBuzz.
• If i is a multiple of 3 (but not 5), print Fizz.
• If i is a multiple of 5 (but not 3), print Buzz.
• If iis not a multiple of 3 or 5, print the value of i.
Sample Output
1
12
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
*/

using System;

namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
