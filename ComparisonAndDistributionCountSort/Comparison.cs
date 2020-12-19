using System;
using System.Collections.Generic;
using System.Text;

namespace ComparisonAndDistributionCountSort
{
    public static class Comparison
    {
        // Low to High sort
        public static void BubbleSort(int[] array, int arrayLength)
        {
            int i, j, temp;
            bool swapped;

            for (i = 0; i < arrayLength - 1; i++)
            {
                swapped = false;
                for (j = 0; j < arrayLength - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // SWAPP
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }

    }
}
