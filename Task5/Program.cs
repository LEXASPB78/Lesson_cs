// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;

    return 0;
}

System.Console.WriteLine(FindQuarter(4,7));
System.Console.WriteLine(FindQuarter(-19,7));
System.Console.WriteLine(FindQuarter(-1,3));
System.Console.WriteLine(FindQuarter(4,-8));
System.Console.WriteLine(FindQuarter(4,0));


