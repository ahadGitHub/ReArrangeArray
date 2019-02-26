using System;
using System.Collections.Generic;
using System.Text;

namespace ReArrangeArray
{
    public class ReadValues
    {
        public static List<string> ReadArrayToReArrange()
        {
            List<string> listToBeReArranged = new List<string>();

            Console.Write("Enter Values ( Separated by Space ) : ");
            string input = Console.ReadLine().Trim();
            string[] values = input.Split(' ');
            
            foreach (var value in values)
            {
                listToBeReArranged.Add(value);
            }
            
            return listToBeReArranged;
        }
    }
}
