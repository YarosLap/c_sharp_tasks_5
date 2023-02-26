Console.Clear();

Console.WriteLine($"Введите количество элементов массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(arraySize, 1, 10);
Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях (если первый элемент принимаем за нулевой): {randomNumber}");

int RandomNumbers(int ElementNumbers, int min, int max)
  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");
    Console.Write("[ ");
    for (int i = 0; i < randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(-99, 100);

      Console.Write(randomNumber[i] + " ");

      if (i % 2 != 0)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
    Console.Write("]");
  return sumElements;
  }

