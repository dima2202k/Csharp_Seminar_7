//Задание 3

void main ()
{
    int [] arrayNumber = [3, 6, 8, 1, 6, 0];
    printNumber(arrayNumber, arrayNumber.Length - 1);
}

void printNumber (int[] arrayNumber, int counter)
{
    if (counter < 0)
    {
        return;      
    }
    System.Console.Write($"{arrayNumber[counter]} ");

    printNumber(arrayNumber, counter - 1);
}

main();