// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//Console.WriteLine();
int count = 0;

foreach (int i in size)
{
    if (i > 0)
        count++;

}
Console.WriteLine(count);


