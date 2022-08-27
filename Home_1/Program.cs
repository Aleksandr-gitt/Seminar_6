// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Numbers(int[] Num)
{
    int length = Num.Length;
    int count = 0;
    for(int i = 0; i < length; i++)
    {
        if(Num[i] > 0) count++;
        Console.Write($"{Num[i]} ");
    }

    Console.Write($" из них, больше 0 -> {count}");
}

// int[] Array = new int[0];
void Chose()
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int j = 0;
int length = 1;
Array[j] = num;
// for(chose == y; j++; length++)
// int j = 0;
// int length = 1;
// Array[j] = num;


}
Console.WriteLine("Желаете ввести число ? (y/n)");
int chose = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[0];
if(chose == 1) Chose();
else Numbers(Array[length]);



