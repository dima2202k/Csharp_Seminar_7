// Задание 1

void main(int m, int n)
{
    int max = m;
    int min = n;

    if (m > n)
    {
        max =  m; 
        min = n; 
    } else
    {
        max = n;
        min = m;
    }
    printNatural(max, min);
}

void printNatural(int max, int min)
{
    if (min == max - 1) return;    
    System.Console.Write($"{min + 1} ");
    printNatural(max, min + 1);
}

int m = 12;
int n = 57;
main(m, n);