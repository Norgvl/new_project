int[] array = new int[10];

void fillArray(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
        collection[i] = new Random().Next(0, 10);
    }

}

void printArray(int[] list)
{
    int length = list.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(list[i] + " ");

    }
}

int find = 11;
int index = 0;

void findNumber(int[] array, int find)
{
    int size = array.Length;
    for (int index = 0;  index < size; index++)
    {

        if (array[index] == find)
        {

            Console.WriteLine($"Индекс числа {find} - {index}. Успех");
            break;
        }
    }
   
}

fillArray(array);
printArray(array);
findNumber(array, find);
