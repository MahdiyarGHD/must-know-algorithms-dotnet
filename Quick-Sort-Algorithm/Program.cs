int[] unsortedArray = [10, 15, 2, 1, 6, 12, 5, 7];
QuickSort(unsortedArray);

Console.WriteLine(string.Join(", ", unsortedArray));

static void QuickSort(int[] unsortedArr)
{
    Sort(unsortedArr, 0, unsortedArr.Length - 1); 
}

static void Sort(int[] unsortedArr, int low, int high) 
{
    if (low < high)  
    {
        int pivotIndex = Partition(unsortedArr, low, high);
        Sort(unsortedArr, low, pivotIndex - 1);
        Sort(unsortedArr, pivotIndex + 1, high); 
    }
}

static int Partition(int[] array, int low, int high)
{
    int pivot = array[high];

    int i = low - 1; 

    for (int j = low; j < high; j++)
    {
        if (array[j] <= pivot)
        {
            i++;
            Swap(array, i, j); 
        }
    }

    Swap(array, i + 1, high); 

    return i + 1; 
}

static void Swap(int[] arr, int i, int j)
{
    (arr[j], arr[i]) = (arr[i], arr[j]);
}