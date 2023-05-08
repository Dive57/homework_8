// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Консоль.Очистить();
Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу задаем матрицу, которую можно перемножить, т.е. количество столбцов первого равно количеству строк второй");
Console.WriteLine($"\nВведите размеры матрицы и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Включить диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
СоздатьМассив(перваяМатрица);
Console.WriteLine($"\nПервая матрица:");
WriteArray (первая матрица);

int[,] secomdMartrix = new int[n, p];
CreateArray (вторая матрица);
Console.WriteLine($"\nВторая матрица:");
WriteArray (вторая матрица);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix (первая матрица, вторая матрица, результирующая матрица);
Console.WriteLine($"\nПроведение первой и второй матрицы:");
ЗаписатьМассив(РезультатМатрица);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength (0); i++)
  {
    for (int j = 0; j <resultMatrix.GetLength(1); j++)
    {
      целая сумма = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        сумма += первая матрица [i, k] * вторая матрица [k, j];
      }
      Матрица результата[i,j] = сумма;
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