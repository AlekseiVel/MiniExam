// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами

string[] FillArray(int enteredElements)
{
    string[] array = new string[enteredElements];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива из {enteredElements}:");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
  Console.WriteLine();  
}

string[] ChangeArrayForStringLenght(string[] array, int stringLenght)
{
  string[] changedArray = {};
  int size = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= stringLenght)
    {
      size++;
      Array.Resize(ref changedArray, size);
      changedArray[size - 1] = array[i];
    }
  }
  return changedArray;
}

Console.WriteLine("Введите желаемый размер массива?");
int size = int.Parse(Console.ReadLine()!);
string[] array = FillArray(size);
Console.WriteLine("Введенный массив строк:");
PrintArray(array);
string[] finalArray = ChangeArrayForStringLenght(array, 3);
Console.WriteLine("Новый массив с длиной элементов в три символа: ");
PrintArray(finalArray);
