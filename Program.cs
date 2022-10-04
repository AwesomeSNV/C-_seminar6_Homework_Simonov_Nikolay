// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите желаемые числа через пробел:");
int[] array = ReadNumbers(Console.ReadLine()!);
PrintArray(array);

int[] ReadNumbers(string input)
{
    int count = 1;
    for(int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
    int[] numbers = new int [count];
    int index = 0;
    for(int i = 0; i < input.Length; i++)
    {
        string temp = "";
        while(input[i] != ' ')
        {
            if(i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
if(count == 1)
{
    Console.WriteLine($"Вы ввели {count} число больше нуля. Вы великолепны!");
}
if(count > 1 && count < 5)
{
    Console.WriteLine($"Вы ввели {count} числа больше нуля. Вы великолепны!");
}
if(count > 4)
{
    Console.WriteLine($"Вы ввели {count} чисел больше нуля. Вы великолепны!");
}
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)