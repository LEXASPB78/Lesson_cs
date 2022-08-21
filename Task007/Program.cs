
void Increase(int[] x)
{
    x[0] = x[0] * 2;    
}

int[] numbers = new int[1];
numbers[0] = 10;
Increase(numbers);
Console.WriteLine(numbers[0]);