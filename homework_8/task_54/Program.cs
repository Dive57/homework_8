// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Консоль.Очистить();
Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементов каждой строки двумерного массива.");
Console.WriteLine($"\nВведите размер массива mxn и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");

int InputNumbers(string v)
{
    throw new NotImplementedException();
}

int n = InputNumbers("Введите n: ");
int range = InputNumbers("Включить диапазон: от 1 до ");

int[,] массив = новый int[m, n];
СоздатьМассив(массив);
ЗаписатьМассив(массив);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(массив);
ЗаписатьМассив(массив);

недействительным OrderArrayLines (массив int [,])
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        если (массив [i, k] < массив [i, k + 1])
        {
          int temp = массив [i, k + 1];
          массив [i, k + 1] = массив [i, k];
          массив [я, к] = темп;
        }
      }
    }
  }
}

int InputNumbers (строковый ввод)
{
  Консоль.Запись(ввод);
  int output = Convert.ToInt32(Console.ReadLine());
  обратный вывод;
}

недействительным CreateArray (массив int [,])
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      массив [i, j] = новый Random(). Далее (диапазон);
    }
  }
}

недействительным WriteArray (массив int [,])
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(массив [i, j] + " ");
    }
    Консоль.ЗаписьЛинии();
  }
}