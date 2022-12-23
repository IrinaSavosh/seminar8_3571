// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.Clear();

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 9)
{
   int[,] matr = new int[rowsCount, columsCount];
   Random rand = new Random();

   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         matr[i, j] = rand.Next(leftRange, rightRange + 1);
      }
   }
   return matr;
}

int GetNumber(string massege)
{
   Console.Write(massege);
   return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         Console.Write(matr[i, j] + " ");
      }
      Console.WriteLine();
   }
}

int[,] Task(int[,] matr)
{
   int minI = -1;
   int minJ = -1;
   int min = 999;
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         if (matr[i, j] < min)
         {
            minI = i;
            minJ = j;
            min = matr[i, j];
         }
      }
   }
   int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
   int ii = 0;
   int jj = 0;
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      if (i != minI)
      {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
            if (j != minJ)
            {
               result[ii, jj] = matr[i, j];
               jj++;
            }
         }
         jj = 0;
         ii++;
      }
   }
   return result;
}
int rows = GetNumber("Введите число строк:");
int columns = GetNumber("Введите число столбцов:");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);
Console.WriteLine();

int[,] res = Task(matrix);
PrintMatrix(res);