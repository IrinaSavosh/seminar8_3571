// Задайте двумерный массив. Напишите программу, которая упорядочит
// по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8


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

int[,] NewArray(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      int countJ = matr.GetLength(1);
      for (int j = 0; j < countJ; j++)
      {
         int max = 0;
         int c = 0;
         int countC = 0;
         while (c < countJ)
         {
            if (matr[i, c] > max)
            {
               max = matr[i, c];
               countC = c;
            }
            c++;
         }
         matr[i, countC] = matr[i, countJ - 1];
         matr[i, countJ - 1] = max;
         countJ = countJ - 1;
         j = -1;
      }
   }
   return matr;
}

int rows = GetNumber("Введите число строк:");
int columns = GetNumber("Введите число столбцов:");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);
Console.WriteLine();


NewArray(matrix);
PrintMatrix(matrix);
