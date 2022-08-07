Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
int digit = number % 10;
System.Console.WriteLine($"Последняя цифра равна {digit}");
}
else 
{
    System.Console.WriteLine("Введеное число не трехзначное");
}