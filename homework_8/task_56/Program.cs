// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Консоль.Очистить();
Console.WriteLine($"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine($"\nВведите размер массива mxn и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Включить диапазон: от 1 до ");

int[,] массив = новый int[m, n];
СоздатьМассив(массив);
ЗаписатьМассив(массив);

интервал minSumLine = 0;
int sumLine = SumLineElements (массив, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements (массив, i);
  если (sumLine > tempSumLine)
  {
    СуммаСтрока = временнаяСуммаСтрока;
    минимальнаяСуммаЛиния = я;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строки с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements (int [,] массив, int i)
{
  int sumLine = массив [i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += массив[i,j];
  }
  вернуть суммуСтрока;
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

void WriteArray (массив int[,])
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(массив [i,j] + " ");
    }
    Консоль.ЗаписьЛинии();
  }
}