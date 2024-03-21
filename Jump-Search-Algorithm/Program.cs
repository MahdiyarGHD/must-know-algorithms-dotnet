int[] sortedArr = [.. Enumerable.Range(1, 10000)];
int target = 6436;

int result = JumpSearch(sortedArr, target);

Console.WriteLine(result);

static int JumpSearch(int[] sortedArray, int target)
{
    int blockSize = (Int32)Math.Sqrt(sortedArray.Length);
    int blockCount = sortedArray.Length / blockSize;
    for (int i = 0; i < blockCount; i++)
    {
        int result = BinarySearch(sortedArray[(i * blockSize)..((i + 1) * blockSize)], target);
        if (result == -1)
            continue;

        return (i * blockSize) + result;
    }

    return -1;
}


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