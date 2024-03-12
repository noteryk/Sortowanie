using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 8, 5, 7, 3, 1 };

        Console.WriteLine("Przed sortowaniem: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Sortowanie tablicy za pomocą InsertionSort
        InsertionSort(numbers);

        Console.WriteLine("Po sortowaniu: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }
}
