int[] arrayToSort = [6, 2, 4, 8, 9, 7, 12, 13];
BubbleSort(arrayToSort);

Console.WriteLine(string.Join(", ", arrayToSort));


static void BubbleSort(int[] arrayToSort)
{
    int sortedItems;
    while (true)
    {
        sortedItems = 0;
        for (int i = 0; i < arrayToSort.Length - 1; i++)
            if (arrayToSort[i + 1] < arrayToSort[i])
            {
                Swap(arrayToSort, i + 1, i);
                sortedItems++;
            }

        if (sortedItems == 0)
            break;
    }
}


static void Swap(int[] arr, int i, int j)
{
    (arr[j], arr[i]) = (arr[i], arr[j]);
}