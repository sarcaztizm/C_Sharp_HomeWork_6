// Пользователь вводит с клавиатуры M чисел.
// ПОсчитайте, сколько чисел больше 0 ввел пользователь.

Console.Clear();

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
int [] UserArray = new int [M];

int [] ArrayInput (int [] array)
{
    for (int i = 0; i < M; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int AboveZero (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.WriteLine("Введите числа:");
ArrayInput(UserArray);
Console.WriteLine("Количество положительных чисел: " + AboveZero(UserArray));
