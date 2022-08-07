Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number % 10;
System.Console.WriteLine($"Последняя цифра равна {digit}");

