Console.Clear();
void FillArr(string[,] table)
{
    for (int i = 0; i<table.GetLength(0); i++)
    {
        if (i%2==0)
        {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            
            if (j == 7  || j == 14)
            {
            table[i,j] = "+"; 
            }
            else if (i == 0 && j > 7  && j < 14 || i == table.GetLength(0)-1 && j > 7  && j < 14)
            {
                table[i,j] = "+";

            }
           
            else
            {
                table[i,j] = " ";
            }

        }
        }
        else
        {
            for (int j = 0; j < table.GetLength(1); j++)
        {
            if (j == 8  || j == 13)
            {
            table[i,j] = "+"; 
            }
        
            else
            {
                table[i,j] = " ";
            }

        }
        }
        
    }
}



string[,] table = new string[21,21];


void PrintArr(string[,] table)
{
    for (int i = 0; i<table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i,j]);

        }
        Console.WriteLine();
    }
}

void FillImage(int i, int j)
{
    if (table[i,j] == " ")
    {
        table[i,j] = "+";
        FillImage(i-1,j);
        FillImage(i,j-1);
        FillImage(i+1,j);
        FillImage(i,j+1);

    }
   

}

FillArr(table);
// FillImage(2, 8);
PrintArr(table);