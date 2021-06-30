using System;
using System.Linq;
//There is a large pile of socks that must be paired by color. Given a list of integers
//representing the color of each sock, determine how many pairs of socks with matching
//colors are there?

namespace How_Many_Pairs_of_Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "green", "green", "red", "blue", "blue", "blue", "purple", "green", "green" };
            Console.WriteLine(NumberOfPairs(array));
        }

        static int NumberOfPairs(string[] array)
        {
            int num = 0;
            array = array.OrderBy(x => x).ToArray();

            for (int i = 0; i < array.Length;)
            {
                int last_index = Array.LastIndexOf(array, array[i]);
                num += (last_index - i + 1) / 2;
                i = ++last_index;
            }

            return num;
        }

    }
}