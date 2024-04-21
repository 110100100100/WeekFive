int []arr = {4, 12, 7, 8, 1, 6, 9};
int index = FindMinValueInArray(arr);
System.Console.WriteLine("Số nhỏ nhất trong mảng là : " + arr[index]);

static int FindMinValueInArray(int[] array)
{
    int min = array[0];
    int index = 0;

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }

    return index;
}
