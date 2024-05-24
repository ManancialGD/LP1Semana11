using System;
using System.Collections.Generic;
using System.Linq;

public static class BeforeUtils
{
    // This method returns an enumerable containing the items from the original enumerable
    // that are less than the specified item according to the ordering
    public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : struct, IComparable<T>
    {
        // Use LINQ to filter the items that are less than the specified item
        return items.Where(i => i.CompareTo(item) < 0);
    }
}
