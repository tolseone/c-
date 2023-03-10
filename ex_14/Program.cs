int[] arr = { 5, 2, 4, 1, 6, 2, 4, 7, 8 };

void PrintArray( int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortminmax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for ( int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPos]) minPos = j;
    }
        int tmp = array[i];
        array[i] = array[minPos];
        array[minPos] = tmp;
    }

}

void SelectionSortmaxmin(int[] array)
{
   for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;

        for ( int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array[maxPos]) maxPos = j;
    }
        int tmp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = tmp;
    }
}

PrintArray(arr);
SelectionSortmaxmin(arr);

PrintArray(arr);