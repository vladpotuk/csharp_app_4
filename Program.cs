using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 1, 5, 2, 4 };
        IntArray array = new IntArray(arr);

        array.Display();

        int valueToCompare = 3;
        Console.WriteLine($"Кількість елементів менших за {valueToCompare}: {array.Less(valueToCompare)}");
        Console.WriteLine($"Кількість елементів більших за {valueToCompare}: {array.Greater(valueToCompare)}");
    }
}

