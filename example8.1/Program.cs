int a = 4;
int b = 5;
int c = 12;
int d = 76;
int f = 98;
int g = 9;
int h = 0;
int i = 13;
int j = -10;

int maxNumber(int a, int b, int c)
{
    int max = a;
    if (b>max) max = b;
    if (c>max) max = c;
    return max;
}

int finalMax = maxNumber(maxNumber(a,b,c), maxNumber(d,f,g), maxNumber(h, i, j));

Console.WriteLine(finalMax);