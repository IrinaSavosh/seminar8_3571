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



int[,] GetMatrix(int rowsCount, int columsCount)
{
   int[,] matr = new int[rowsCount, columsCount];
   Random rand = new Random();

   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         matr[i, j] = rand.Next(0, 10);
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
   int minSum = 5000;
   
   int g = -1;
   //      0      3
   for (int i=0; i < matr.GetLength(0);i++)     // 0 - это строка, 1 - это столбец
   {
      int sum = 0;


      for (int j = 0; j < matr.GetLength(1); j++)
      {// 3      1         2
         sum = sum + matr[i, j];
         //    3        

      }
      if (minSum > sum)
      {//   3      3
         minSum = sum;
         g++;
      }
      
   }
   Console.WriteLine($"Номер строки с наименьшей суммой элементов: строка {g}");
}

// int rows = GetNumber("Введите число строк:");
// int columns = GetNumber("Введите число столбцов:");

Random rowsRandom = new Random();    // рандомное количество строк
int valueR = rowsRandom.Next(1, 10);

Random columnsRandom = new Random();        // рандомное количество столбцов
int valueC = columnsRandom.Next(1, 10);

int[,] matrix = GetMatrix(valueR, valueC);

PrintMatrix(matrix);
Console.WriteLine();


Summ(matrix);