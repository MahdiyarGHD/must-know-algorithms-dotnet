int[] sortedArr = [.. Enumerable.Range(1, 100)];
int target = 76;

int result = BinarySearch(sortedArr, target);

Console.WriteLine(result);


static int BinarySearch(int[] sortedArray, int target)
{
    int targetIndex = 0;
    int high = sortedArray.Length - 1;

    while (targetIndex <= high)
    {
        int middleIndex = (targetIndex + high) / 2;
        int middleValue = sortedArray[middleIndex];

        if (middleValue == target)
            return middleIndex; 
        else if (middleValue > target)
            high = middleIndex - 1; 
        else
            targetIndex = middleIndex + 1; 
    }

    return -1; 
}