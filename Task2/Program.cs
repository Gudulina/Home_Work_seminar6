/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double[,] data = new double[2, 2];
double[] point = new double[2];

void Coefficients()
{
  for (int i = 0; i < data.GetLength(0); i++)
    {
      Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
      for (int j = 0; j < data.GetLength(1); j++)
        {
          if (j == 0) Console.Write($"Введите коэффициент k: ");
          else Console.Write($"Введите коэффициент b: ");
          data[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Equation(double[,] data)
{
  point[0] = (data[1, 1] - data[0, 1]) / (data[0, 0] - data[1, 0]);
  point[1] = point[0] * data[0, 0] + data[0, 1];
  return point;
}

void  Intersection(double[,] data)
{
  if (data[0, 0] == data[1, 0] && data[0, 1] == data[1, 1])
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (data[0, 0] == data[1, 0] && data[0, 1] != data[1, 1])
  {
    Console.Write($"\nПрямые параллельны");
  }
  else
  {
    Equation(data);
    Console.Write($"\nТочка пересечения прямых: ({point[0]}, {point[1]})");
  }
}

Coefficients();
Intersection(data);