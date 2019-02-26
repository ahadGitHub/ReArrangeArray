using System;
using System.Collections.Generic;
using System.Text;

namespace ReArrangeArray
{
    public class ReadIndexAndArrange
    {
        public static void ReadUserIndex(List<string> listToBeReArranged, int count)
        {
            Console.Write("Enter Initial Index : ");
            int initialIndex = Convert.ToInt32(Console.ReadLine());

            if (initialIndex > count - 1 || initialIndex < 0)
            {
                Console.WriteLine("Invalid Index.");
            }
            else
            {
                Console.Write("Enter the Final Index : ");
                int newIndex = Convert.ToInt32(Console.ReadLine());

                if (newIndex > count - 1 || newIndex < 0)
                {
                    Console.WriteLine("Invalid Index.");
                }
                else
                {
                    var newOrder = ReArrange.RePosition(listToBeReArranged, initialIndex, newIndex);

                    foreach (var value in newOrder)
                    {
                        Console.Write(value + " ");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
