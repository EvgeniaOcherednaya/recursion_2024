int[] array = { 1, 2, 5, 0, 10 };
int LastNumber = array.Length - 1;

void ShowArray(int[] arr, int size)
{
    if (size == 0)
    {
        Console.Write(arr[size]);
        return;
    }
    Console.Write(arr[size] + " ");
    ShowArray(array, size - 1);

}

ShowArray(array, LastNumber);