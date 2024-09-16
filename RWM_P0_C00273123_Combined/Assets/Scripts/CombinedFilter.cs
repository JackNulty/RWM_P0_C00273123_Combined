using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] array)
    {
        int[] temp = RemoveDupes.Remove(array);

        int[] temp2 = RemoveOddNumbersFilter.RemoveOddNumbers(temp);

        return temp2;

    }
}
