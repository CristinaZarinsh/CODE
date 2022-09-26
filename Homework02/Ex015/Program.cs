// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую деньнедели");
int numDay = Convert.ToInt32(Console.ReadLine());

void Day(int num)
{
    if(num == 7 || num == 6)
    {
        Console.WriteLine("Является выходным");
    }
    else if(num >= 1 && num <= 5)
    {
        Console.WriteLine("Не является выходным");
    }
    else
    {
        Console.WriteLine("Введено неправильное значение");
    }
}

Day(numDay);