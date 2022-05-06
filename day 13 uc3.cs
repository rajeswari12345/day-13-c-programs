﻿
using system;
public class MainClass
{
    // determines the largest of three Comparable objects
    public static <T extends Comparable<T>> T maximum(T x, T y, T z)
    {
        T max = x; // assume x is initially the largest

        if (y.compareTo(max) > 0)
            max = y; // y is the largest so far

        if (z.compareTo(max) > 0)
            max = z; // z is the largest

        return max; // returns the largest object
    } // end method maximum

    public static void main(String args[])
    {
        Console.WriteLine("Maximum of %d, %d and %d is %d\n\n", 3, 4, 5, maximum(3, 4, 5));
        Console.WriteLine ("Maximum of %.1f, %.1f and %.1f is %.1f\n\n", 6.6, 8.8, 7.7, maximum(6.6,
            8.8, 7.7));
        Console.WriteLine("Maximum of %s, %s and %s is %s\n", "peach", "apple", "banana", maximum(
            "peach", "apple", "banana"));
    }
}
