// // Vid 1 
// void Method1()
// {
//     Console.WriteLine("Author: ");
// }
// // vid 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }


// void Method21(string msg, int count)
// {
//     int i =0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;

//     }
    
// }

// Method21(msg: "Massage", count: 4);

// // vid3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year); 

// // vid4

// string Method4(int count, string c)
// {
//     int i =0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = c + result;

//         i++;
//     }
//     return result;


// }

// string a = Method4(count: 10, c: "asd");

// Console.WriteLine(a);

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");

    }
    Console.WriteLine();
}
*/

// string text = "abd aidw - awdaw . awdnad";

// string[] arrText = new string [text.Length];

// void Replace(string[] arrText, string text, char oldValue, char newValue)
// {

//     for (int i = 0; i < text.Length; i++)
//     {
//         arrText[i] = $"{text[i]}";
//         if (arrText[i] == $"{oldValue}") arrText[i] = $"{newValue}";
//         Console.Write(arrText[i]);
//     }

// }

// Replace(arrText, text, ' ', '|');


int[] arr = new int[10];

void FillAndPrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,10);
        Console.Write(arr[i]+ " ");
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        
        Console.Write(arr[i]+ " ");
    }
}

void SelectionSort(int[] arr)
{
    int temp1 = 0;
    int index = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        temp1 = arr[i];
        index = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                index = j;
                arr[i] = arr[j];
            }
        }
        arr[index] = temp1;
    }
}


FillAndPrintArr(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArr(arr);

