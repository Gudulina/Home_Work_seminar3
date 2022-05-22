// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int n)
{
    double[] nums = new double[n];
    int i = 0;

    Console.Write($"{n} -> ");

    while (i < n)
    {
        nums[i] = Math.Pow((i + 1), 3);
        Console.Write($"{nums[i]}, ");
        i++;
    }  
Console.WriteLine();  
}

Cube(8);
Cube(3);
Cube(10);