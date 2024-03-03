using System;

public class IntArray : ICalc
{
    private int[] elements;
    private int length;
    private int sum;

    public IntArray(int[] arr)
    {
        elements = arr;
        length = elements.Length;
        sum = CalculateSum();
    }

    public int Length => length;

    public int Sum => sum;

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (var element in elements)
        {
            if (element < valueToCompare)
                count++;
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (var element in elements)
        {
            if (element > valueToCompare)
                count++;
        }
        return count;
    }

    private int CalculateSum()
    {
        int total = 0;
        foreach (var element in elements)
        {
            total += element;
        }
        return total;
    }

    public void Display()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Довжина масиву: {Length}");
        Console.WriteLine($"Сума елементів масиву: {Sum}");
    }
}
