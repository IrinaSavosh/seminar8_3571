// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();

Random rowsRandom = new Random();    // рандомное количество строк
int valueR = rowsRandom.Next(1, 4);

Random columnsRandom = new Random();        // рандобмное количество столбцов
int valueC = columnsRandom.Next(1, 4);

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

// int GetNumber(string massege)
// {
//    Console.Write(massege);
//    return Convert.ToInt32(Console.ReadLine());
// }

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

int[,] Product(int[,] matr1, int[,] matr2)
{
   int[,] result = new int[matr1.GetLength(0), matr1.GetLength(1)];

   for (int i = 0; i < matr1.GetLength(0); i++)
   {
      for (int j = 0; j < matr1.GetLength(1); j++)
      {
         result[i, j] = matr1[i, j] * matr2[i, j];
      }
   }
   return result;
}



int[,] matrix = GetMatrix(valueR, valueC);
int[,] massive = GetMatrix(valueR, valueC);

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(massive);
Console.WriteLine();
Console.WriteLine();
int[,] res = Product(matrix, massive);
PrintMatrix(res);