// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Sum(int a)
{
    int result = 0;
    for (int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}

System.Console.WriteLine(Sum(5));