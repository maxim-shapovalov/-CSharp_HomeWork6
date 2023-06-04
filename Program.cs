
// Задача 41 начало
int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите число № {i + 1} из {n}:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void CheckArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Вы ввели {count} чисел больше нуля");
}
// Задача 41 конец

// Задача 43 начало
void FindCrossPoint(int b1, int k1, int b2, int k2)
{
    double result = 0;

    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
 
Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
}
// Задача 43 конец


Console.Clear();
Console.WriteLine("\n========= Список задач ==========\n");
Console.WriteLine("1 - Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("2 - Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("0 - Выход\n");
Console.Write("Выберите задачу 1 или 2:   ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (task)
{
    case 1:
        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3
        Console.WriteLine("Введите количество чисел N ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] array = FillArray(N);
        CheckArray(array);
        break;

    case 2:
        // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
        Console.WriteLine("Введите b1 ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите k1 ");
        int k1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b2 ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите k2 ");
        int k2 = Convert.ToInt32(Console.ReadLine());
        FindCrossPoint(b1, k1, b2, k2);
        break;


    case 0:
        Console.WriteLine("Всего хорошего!");
        break;
}
Console.WriteLine();