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
Console.Write("Введите A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B = ");
int B = Convert.ToInt32(Console.ReadLine());
if (B > 0)
{
Console.Write("A в степени B = ");
Console.Write(Exponentiation(A,B));
}
else 
Console.Write("Ошибка, число B не натуральное");