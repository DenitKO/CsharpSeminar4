int Exponentiation(int digit, int degree)
{
    int index = 1;
    int ExpDigit=digit;
    if (degree > 0)
    {
        while (index < degree)
        {
            ExpDigit=ExpDigit*digit;
            index++;
        }
    return ExpDigit;
    }
    if (degree < 0)
    {
            while (index < degree)
        {
            ExpDigit=ExpDigit*digit;
            index--;
        }
    return 1/ExpDigit;
    }
    else 
    return 1;
}
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int CountOfDigit(int WhatCount)
{ 
    int i = 0;
    for (; WhatCount>0; i++)
    {
        WhatCount/=10;
    }
    return i;
}

int n = CountOfDigit(number);
int SumOfDigit = 0;

for (int i = 0; i < n; i++)
{
    SumOfDigit=SumOfDigit+(number/Exponentiation(10, n-i-1) % 10);
}
Console.Write("Сумма этих цифр равна = ");
Console.WriteLine(SumOfDigit);