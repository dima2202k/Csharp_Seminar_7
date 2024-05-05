//Задание 2

void main ()
{
    int n = 1;
    int m = 1;
    System.Console.WriteLine(calculateAkkerman(n, m));
}

int calculateAkkerman(int n, int m) 
{
    if (n == 0)  
    {
        return  m += 1;
        
    } else if (m == 0)
    {
        calculateAkkerman(n - 1, 1);  

    } else if (m != 0 && n != 0)
    {
        calculateAkkerman(n - 1, calculateAkkerman(n, m - 1));
    }

    return(m);

}

main();