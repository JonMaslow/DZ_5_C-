/*Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int [] InitRandomArray (int length)
{
    int [] resultArray = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = rnd.Next(-10,10);
    }
    return resultArray;
}

void PrintArray(int [] array)
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

int SummNotEvenEl(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        summ += array[i];
    }
    return summ;
}   
int length = GetNumber("Введите длину массива:");
int [] randomArray =InitRandomArray(length);
PrintArray(randomArray);
int summ = SummNotEvenEl(randomArray);
Console.WriteLine($"Сумма значений не чётных элементов в данном массиве равна {summ}");

