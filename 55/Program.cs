// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void Recombinate (int [,] matrix, int [,] matrixRez)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrixRez[j,i]= matrix[i,j];
      }
   }
}
// int[,] ReplaceMatrInside(int[,] matr)
// {

//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//       for (int j = 0; j < matr.GetLength(0); j++)
//       {
//          ReplaceMatrInside(int[,] matr);

//          // int temp = matr[i, j];
//          // matr[i, j] = matr[j, i];
//          // matr[j, i] = temp;

//       }

//    }


   // else
   // {
   //    Console.WriteLine("Изменение не возможно");
   // }
//    return matr;
// }

int rows = GetNumber("Введите число строк:");
int columns = GetNumber("Введите число столбцов:");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);
Console.WriteLine();
// ReplaceMatrInside(matrix);
int [,] matrixRez = new int[columns, rows];
Recombinate(matrix, matrixRez);
PrintMatrix(matrixRez);
