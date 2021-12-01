using System;
using System.Linq;

namespace MixMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string of numbers separated by commas and hit enter when finished.");
            string input = Console.ReadLine();
            //parse into array based on commas
            int[] ArrOfNums= Array.ConvertAll<string, int>(input.Split(','), Convert.ToInt32);
            //sort array
            Array.Sort(ArrOfNums);
            //establish min and max
            int min = ArrOfNums[0];
            int max = ArrOfNums[ArrOfNums.Length - 1];

            //format output
            Console.Write("MixMax ([");
            //for (int i=0; i > ArrOfNums.Length-1; i++)
            foreach(int i in ArrOfNums)
            {
                Console.Write(i);
                Console.Write(",");
            }
            Console.Write(")] -> [");
            Console.Write(min);
            Console.Write(",");
            Console.Write(max);
            Console.Write("]");

            //sort array
            //set min and max
            //print output
            //end
        }
    }
}
