//Задача 35. Определить, присутствует ли в заданнои массиве некоторое число.
Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;

Console.Write("Ищем = ");
Console.WriteLine(find);
Console.WriteLine("Массив: ");

while (index < count)
{
    array[index] = new Random().Next(1, 22);
    Console.Write(array[index] + " ");
    index += 1;
}

Console.WriteLine();

index = 0;
bool element = false;

while(index < count)
{
    if (array[index] == find)
    {
        element = true;
    }
    
    index += 1;
}
if (element)
{
    Console.WriteLine("Такой элемент есть");
}
else
{
    Console.WriteLine("Такого числа нет");
}

Console.WriteLine("END");