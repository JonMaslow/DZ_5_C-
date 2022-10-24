/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int [] InitRandomArray (int length)
{
    int [] resultArray = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = rnd.Next(100,1000);
    }
    return resultArray;
}

void PrintArray(int [] array)
{   Console.WriteLine("Случайный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int resultArray = int.Parse(Console.ReadLine()??"");
    return resultArray;
}

int GetEvenNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        count += 1;
    }
    return count;
}

int length = GetNumber("Введите длинну массива: ");
int [] arrayRandom = InitRandomArray(length);
PrintArray(arrayRandom);
int number = GetEvenNumber(arrayRandom);
Console.Write($"-> массив содержит {number} чётных чисел");
 

