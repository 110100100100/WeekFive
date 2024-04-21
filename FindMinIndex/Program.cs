int []array = {2,3,4,5,6};
int index = MinInArray(array);
System.Console.WriteLine("Số nhỏ nhất trong mảng là: " + index);

static int MinInArray(int []array)
{
    int min = array[0];
    int index = 0;

    for(int i = 1 ; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }

    return index;
}
