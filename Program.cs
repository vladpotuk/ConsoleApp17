using System;
using System.Collections.Generic;

public class ArrayHelper
{
    public static int[] GetCommonElements(int[] array1, int[] array2)
    {
        HashSet<int> set1 = new HashSet<int>(array1);
        HashSet<int> set2 = new HashSet<int>(array2);

        set1.IntersectWith(set2);

        int[] result = new int[set1.Count];
        set1.CopyTo(result);
        return result;
    }
}

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };

        int[] commonElements = ArrayHelper.GetCommonElements(array1, array2);

        Console.WriteLine("Загальні елементи перших двох масивів без повторень:");

        foreach (var element in commonElements)
        {
            Console.Write(element + " ");
        }

        Console.ReadLine(); // Пауза перед закриттям консолі
    }
}
