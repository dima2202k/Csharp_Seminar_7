//Задание 2

void main ()
{
    int n = 3;
    int m = 4;
    m  = calculateAkkerman(n, m);
    System.Console.WriteLine(m);
}

int calculateAkkerman(int n, int m) 
{
    if (n == 0)  
    {
        return  m += 1;
        
    } 
    if (m == 0)
    {
        return calculateAkkerman(n - 1, 1);  

    }
    if (m != 0 && n != 0)
    {
        return calculateAkkerman(n - 1, calculateAkkerman(n, m - 1));
    }
    return m;
}

main();