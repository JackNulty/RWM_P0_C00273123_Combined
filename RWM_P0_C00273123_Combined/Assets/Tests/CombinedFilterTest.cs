using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CombinedFilterTest
{
    [Test]
    public void CombinedFilterSimple()
    {
        int[] input = { 1, 1, 2, 3, 5, 7, 9 };
        int[] output = CombinedFilter.combinedFilter(input);
        int[] expected = {2};

        CollectionAssert.AreEqual(expected, output);
    }
}


