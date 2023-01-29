int[] arr = new int[9];
for (int a = 0; a < 9; a++)
{
    arr[a] = new Random().Next(0, 100);
    Console.Write(arr[a] + " ");
}

int maxNumber(int[] arr)
{
    int max = arr[0];
    int i = 0;
    while (i < 9)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        i++;

    }
    return max;
}

int max = maxNumber(arr);
Console.WriteLine(" ");
Console.WriteLine(max);