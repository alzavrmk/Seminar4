// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество вводимых чисел - ");
int m=Convert.ToInt16(Console.ReadLine());

int k=0;
for (int i = 1; i <= m; i++)
{
   Console.Write($"Введите {i} число ");
   int num=Convert.ToInt16(Console.ReadLine()); 
   if (num>0) k++;
}

Console.WriteLine($"Положительных чисел введено - {k} ");