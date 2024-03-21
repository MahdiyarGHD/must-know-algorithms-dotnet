int target = 1;
int[] arr = [1, 4, 6, 5, 8, 9];
int result = LinearSearch(arr, target);

Console.WriteLine(result);


static int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
            return i;
    }

    return -1;
}