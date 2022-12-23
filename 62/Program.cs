// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

Console.Clear();

//этот способ нашла в интернете, немного его разобрала, но есть вопросы.
//Не стала списывать по этой причине. Да и вообще нужно больше практики, раз уж я сижу над одной задачей день)
// !!! Вопрос по коду из интернета.
// Можно как-то по-другому написать --visits? Я понимаю, что это нам выдает,
// но самостоятельно написать иначе это значение не получилось.

// const int n = 6;
// const int m = 8;
// int[,] matrix = new int[n, m];

// int row = 0;
// int col = 0;
// int dx = 1;
// int dy = 0;
// int dirChanges = 0;
// int visits = m;


// for (int i = 0; i < matrix.Length; i++)
// {
//    matrix[row, col] = i + 1;
//    if (--visits == 0)
//    {
//       visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;

//       int temp = dx;
//       dx = -dy;

//       dy = temp;
//       dirChanges++;

//    }

//    col += dx;
//    row += dy;

// }

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 50)
{
   int[,] matrix = new int[rowsCount, columsCount];

   int length = 1;
   int spiral = 0;
   int i = 0;
   int j = 0;
   int n = 1;

   while (length <= matrix.Length)
   {
      while (j < matrix.GetLength(1) - spiral)   // 1 строка вправо
      {     
         matrix[i, j] = length;
         length++;
         j++;
      }
      j = j + spiral - n;
      i = i + n - spiral;

      while (i < matrix.GetLength(0) - spiral)   // 4 столбец вниз
      {
         matrix[i, j] = length;
         length++;
         i++;
      }      
      i = i + spiral - n;
      j = j - n + spiral;

      while (j >= spiral)   // 4 строка влево
      {
         matrix[i, j] = length;
         length++;
         j--;
      }
      j = j + n - spiral;
      i--;
      spiral++;

      while (i >= spiral)   // 1 столбец вверх
      {
         matrix[i, j] = length;
         length++;
         i--;
      }
      i++;
      j++;
      n++;
   }
   return matrix;
}


void PrintMatrix(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         if (matr[i, j] < 10)
         {
            Console.Write(matr[i, j] + "  ");
         }
         else
         {
            Console.Write(matr[i, j] + " ");
         }
      }
      Console.WriteLine();
   }
}

int GetNumber(string massege)
{
   Console.Write(massege);
   return Convert.ToInt32(Console.ReadLine());
}

int rows = GetNumber("Введите число строк:");
int columns = GetNumber("Введите число столбцов:");

int[,] matrix = GetMatrix(rows, columns);



PrintMatrix(matrix);
