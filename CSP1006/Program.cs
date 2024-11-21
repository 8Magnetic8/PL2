using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 100, 99, 150, 199, 20, 89, 1, 4, 3 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", arr));

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted array:");
        Console.WriteLine(string.Join(", ", arr));
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, kIndex = left;
        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
                arr[kIndex++] = leftArray[iIndex++];
            else
                arr[kIndex++] = rightArray[jIndex++];
        }
        while (iIndex < n1)
            arr[kIndex++] = leftArray[iIndex++];
        while (jIndex < n2)
            arr[kIndex++] = rightArray[jIndex++];
    }
}
