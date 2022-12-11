// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(Random random)
{
int[]array = new int[7];
for (int i = 0; i < array.Length; i++)
{
 array[i] = random.Next(-5, 5);
Console.Write(" " + array[i]);
 }
return array;
}

Random A = new Random();

int[
    

int UnevenIndexSum(int[] arr)
{   int result = 0;
    int j = 2;
    for (j = 2; j < arr.Length; j++)
    {
    if (j % 2 == 1 || j % 2 == -1) 
        result = result + arr[j];
    }
        result += arr[1];
    return result;
    } 

Console.WriteLine("           ");
Console.WriteLine(UnevenIndexSum(collection));


