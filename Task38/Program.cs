// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 69.4 -22 0.4 78] ->56
// Диапазон любой, ввод зависит от пользователя. (размер, значения)

int[] collection = {99, 90, 3, 4, 5, 6, 7, 98, 9, 11, 12, 13, 1};

int MiniMaxDiff(int[] array)
{     int result = 0;
      int i = 2;
      int max = array[0];
      int min = array[1];
      if (array[0] < array[1])
    {
       
        max = array[1];
        min = array[0];
    }

     for (i = 2; i < array.Length; i++)
    {
      if (array[i] > max) max = array[i];         
      if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"{min}, {max}");
    result = max - min;
    return result;
}

Console.WriteLine(MiniMaxDiff(collection));