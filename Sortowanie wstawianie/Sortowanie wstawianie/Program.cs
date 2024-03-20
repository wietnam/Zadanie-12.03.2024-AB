using System;

class InsertionSortProgram
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(100);

        Console.WriteLine("Przed sortowaniem:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("\nPo sortowaniu:");
        PrintArray(array);

        int[] sortedArray = new int[array.Length];
        Array.Copy(array, sortedArray, array.Length);
        Array.Sort(sortedArray);

        Console.WriteLine("\nPoprawnie posortowana tablica:");
        PrintArray(sortedArray);

        bool isSortedCorrectly = CompareArrays(array, sortedArray);
        Console.WriteLine($"\nCzy tablica została posortowana poprawnie? {isSortedCorrectly}");
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int current = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = current;
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(100); 
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static bool CompareArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }

        return true;
    }
}
