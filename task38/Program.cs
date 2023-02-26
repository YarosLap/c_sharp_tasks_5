Console.Clear();

Console.WriteLine("Введите количество элементов массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] number = new double[arraySize];

FillArrayRandomNumbers(number);
Console.WriteLine("Сгенерирован следующий массив: ");
PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}

Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}