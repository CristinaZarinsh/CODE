// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number1 = 654;
int number2 = 78;
int number3 = 32679;

void FindDigit(int num)
{
    if(num >= 1000)
    {
        while(num > 1000)
        {
            num /= 10;
        }
        int result = num % 10;
        Console.WriteLine("result ");
    }
    else if(num >= 100)
    {
        int result = num % 10;
        Console.WriteLine("result");
    }
    else
    {
        Console.WriteLine("Трутьей цифры нет");
    }
}

Console.Write(number1);
FindDigit(number1);
Console.WriteLine();