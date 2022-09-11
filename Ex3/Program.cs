// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int[] GetCubNumber(int number)
{
    int[] cubNumber = new int[number];

//заполнение массива результата
for (int i = 1; i <= number; i++)
{
    cubNumber[i-1] = i * i * i;
}
    return cubNumber;

}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int[] result = GetCubNumber(number);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

