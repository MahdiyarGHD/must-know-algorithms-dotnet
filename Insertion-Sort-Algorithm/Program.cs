int[] unsortedArr = [6, 5, 3, 8, 1, 10];
InsertionSort(unsortedArr);

Console.Write(string.Join(", ", unsortedArr));



static void InsertionSort(int[] unsortedArr)
{
    for (int i = 1; i < unsortedArr.Length; i++)
    {
        int key = unsortedArr[i]; 
        int j = i - 1;

        while (j >= 0 && unsortedArr[j] > key)
        {
            unsortedArr[j + 1] = unsortedArr[j];
            j--;
        }

        unsortedArr[j + 1] = key;
    }
}