/* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
 В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
  Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1 */


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int[] result = ConvertToDecimal(data, info);
PrintArray(result);


int[] ConvertToDecimal(int[] data, int[] info)
{
    int[] arrayRes = new int[info.Length];
    int result = 0;
    int count = 0;
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = count; j < (info[i] + count); j++)
        {
            result = result * 2 + data[j];
        }
        arrayRes[i] = result;
        result = 0;
        count += info[i];
    }
    return arrayRes;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}