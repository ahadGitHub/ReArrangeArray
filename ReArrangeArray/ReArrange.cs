using System;
using System.Collections.Generic;

namespace ReArrangeArray
{
    public class ReArrange
    {
        public static List<string> RePosition(List<string> toBeReArranged, int initialIndex, int newIndex)
        {
            int step = newIndex - initialIndex;
            string temp = toBeReArranged[initialIndex];

            if (step > 0)
            {
                for (int i = 1; i < step + 1; i++)
                {
                    toBeReArranged[initialIndex] = toBeReArranged[initialIndex + 1];
                    initialIndex++;
                }
                toBeReArranged[newIndex] = temp;

                return toBeReArranged;
            }
            else if (step < 0)
            {
                step = Math.Abs(step);
                for (int i = 1; i < step + 1; i++)
                {
                    toBeReArranged[initialIndex] = toBeReArranged[initialIndex - 1];
                    initialIndex--;
                }
                toBeReArranged[newIndex] = temp;

                return toBeReArranged;
            }
            else
            {
                return toBeReArranged;
            }
        }
    }
}
