/*Задача 38:
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double [] InitRandomArray (int length)
{
    double [] resultArray = new double [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = rnd.Next(-100,100);
    }
    return resultArray;
}

void PrintArray(double [] array)
{   Console.WriteLine("Случайный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int resultArray = int.Parse(Console.ReadLine()??"");
    return resultArray;
}

double GetDiffMaxMin(double [] array)
{
    double diffNumber = 0;
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= maxNumber)
        maxNumber = array[i];
        if (array[i] <= minNumber)
        minNumber = array[i];
    }
    Console.WriteLine($"Максимально значение в массиве -> {maxNumber}");
    Console.WriteLine($"Минимально значение в массиве -> {minNumber}");
    diffNumber = maxNumber - minNumber;
    return diffNumber;
}
int length = GetNumber("Введите длину массива:");
double [] array = InitRandomArray(length);
PrintArray(array);
double diffMaxMin = GetDiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным значением в массиве составит {diffMaxMin} единиц");