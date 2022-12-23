// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

Console.Clear();

Random rowsRandom = new Random();    // рандомное количество строк
int valueR = rowsRandom.Next(1, 10);

Random columnsRandom = new Random();        // рандобмное количество столбцов
int valueC = columnsRandom.Next(1, 10);

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

void Summ(int[,] matr)
{
   int minSum = 0;
   int i = 0;
   while (i < matr.GetLength(0))     // 0 - это строка, 1 - это столбец
   {
      int sum = 0;
      int maxSum = 5000;

      for (int j = 0; j < matr.GetLength(1); j++)
      {
         sum = sum + j;
         if (maxSum > sum)
         {
            minSum = sum;
         }
      }
      i++;
   }
   Console.WriteLine($"Номер строки с наименьшей суммой элементов: строка {i - 1}");
}



int[,] matrix = GetMatrix(valueR, valueC);

PrintMatrix(matrix);
Console.WriteLine();


Summ(matrix);