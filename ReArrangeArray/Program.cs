using System;
using System.Collections.Generic;

namespace ReArrangeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listToBeReArranged = ReadValues.ReadArrayToReArrange();
            int count = listToBeReArranged.Count;
            Console.WriteLine("You have entered {0} values.", count);
            Console.WriteLine("The maximum index is {0}.", count -1);

            ReadIndexAndArrange.ReadUserIndex(listToBeReArranged, count);
        }
    }
}
