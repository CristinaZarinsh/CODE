//Задача 35. Определить, присутствует ли в заданнои массиве некоторое число.

int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    index += 1;
}

index = 0;

while(index < count)
{
    if (array[index] == find)
    {
        Console.WriteLine("ДА");
    }
    index += 1;
}

Console.WriteLine("END");