// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 50)
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

void ReplaceMatr(int[,] matr)
{
   int i = 0;
   for (int j = 0; j < matr.GetLength(1); j++)
   {
      int temp = matr[i, j];
      matr[i, j] = matr[matr.GetLength(0) - 1, j];
      matr[matr.GetLength(0) - 1, j] = temp;
   }
}

int rows = GetNumber("Введите число строк:");
int columns = GetNumber("Введите число столбцов:");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);
Console.WriteLine();
ReplaceMatr(matrix);
PrintMatrix(matrix);