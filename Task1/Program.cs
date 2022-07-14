/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write ("Введите числа через пробел: ");
//int volume = Convert.ToInt32 (Console.ReadLine ());
int [] array = Array.ConvertAll (Console.ReadLine().Split(), int.Parse);

int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Элементов больше 0: {count}");
