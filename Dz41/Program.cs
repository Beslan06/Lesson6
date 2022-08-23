Console.Clear();
Console.Write($"Введи число М(количество чисел): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[size];

void InputNumbers(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(massiveNumbers);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
