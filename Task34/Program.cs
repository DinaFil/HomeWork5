// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Диапазон трехзначных чисел, ввод случайный.

Random random = new Random();
int[]array = new int[10];
for (int i = 0; i < array.Length; i++)
{
 array[i] = random.Next(100, 1000);
 Console.Write(" " + array[i]);
 }



int ArrayEvenNumbers(int[] A)
{   int j = 0;
    int result = 0;
    for (j = 0; j < A.Length; j++)
    { 
        if (A[j] % 2 == 0) result = result + 1; 
        
    }
    return result;
    } 

Console.Write("  Количество четных элементов в массиве равно: ");
Console.WriteLine(ArrayEvenNumbers(array));


