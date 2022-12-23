// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

Console.Clear();

// В этой задаче я свернула все методы.
//Есть какая-то комбинация клавиш, которая разворачивает метод/условие/цикл и скрывает? 

int[,,] GetMatrix(int xCount, int yCount, int zCount, int leftRange = 10, int rightRange = 100)
{
   int[,,] matr = new int[xCount, yCount, zCount];
   Random numberRandom = new Random();
   int number = numberRandom.Next(9, 26);

   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         for (int g = 0; g < matr.GetLength(2); g++)
         {
            matr[i, j, g] = number;
            Random termRandom = new Random();
            int term = termRandom.Next(1, 3);
            number += term;
         }

      }
   }
   return matr;
}

int GetNumber(string massege)
{
   Console.Write(massege);
   return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         for (int g = 0; g < matr.GetLength(2); g++)
         {
            Console.Write($"{matr[i, j, g]} ({i}, {j}, {g})");
         }
         Console.WriteLine();
      }

   }
}

int x = GetNumber("Введите число от 1 до 4:");
int y = GetNumber("Введите число от 1 до 3:");
int z = GetNumber("Введите число от 1 до 3:");

if (x < 5 && y < 4 && z < 4)
{
   int[,,] matrix = GetMatrix(x, y, z);
   PrintMatrix(matrix);
   Console.WriteLine();
}
else
{
   Console.WriteLine("Вы ввели неверные параметры");
}


