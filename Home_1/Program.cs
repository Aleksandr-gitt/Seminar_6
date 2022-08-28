// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Numbers(int[] Num)
{
    Console.Write("Вы ввели следующие числа: ");
    int length = Num.Length;
    int count = 0;
    for(int i = 0; i < length; i++)
    {
        if(Num[i] > 0) count++;
        Console.Write($"{Num[i]} ");
    }
    Console.Write($" из них, больше 0 -> {count}");
}

Console.WriteLine("Сколько будем вводить чисел? ");
int len = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[len];
for(int i = 0; i < len; i++)
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Array[i] = num;
}
Numbers(Array);