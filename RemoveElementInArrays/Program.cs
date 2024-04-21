int[] array = { 2, 3, 4, 5, 6 };
System.Console.Write(array + " ");
System.Console.WriteLine("Nhập số cần xóa: ");
int element = int.Parse(Console.ReadLine());
array = RemoveElementInArray(array, element);
System.Console.WriteLine("Mảng sau khi xóa:");
foreach (var item in array)
{
    System.Console.Write(item + " ");
}

static int[] RemoveElementInArray(int[] array, int element)
{
    int index = Array.IndexOf(array, element);
    int[] newArray = new int[array.Length - 1];
    Array.Copy(array, 0, newArray, 0, index);
    Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
    return newArray;
}
