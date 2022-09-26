// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number1 = 654;
int number2 = 78;
int number3 = 32679;

void FindThirdDigit(int num)
{
    if(num >= 1000)
    {
        while(num > 1000)
        {
            num /= 10;
        }
        int result = num % 10;
        Console.WriteLine(result);
    }
    else if(num >= 100)
    {
        int result = num % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Трeтьей цифры нет");
    }
}

Console.WriteLine(number1);
FindThirdDigit(number1);
Console.WriteLine();

Console.WriteLine(number2);
FindThirdDigit(number2);
Console.WriteLine();

Console.WriteLine(number3);
FindThirdDigit(number3);
Console.WriteLine();