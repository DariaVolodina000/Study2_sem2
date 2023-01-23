// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8




// Console.WriteLine("Введите трехзначное число >");
// int num = Convert.ToInt32(Console.ReadLine());

int IntputInt (string massage) // функция, которая пишет сообщение, и принимает число, по сути то же что и выше
{
    Console.WriteLine(massage);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int num = IntputInt ("Введите трехзначное число");
if (num > 99 & num < 1000)
{
    int result = num % 10;
    Console.WriteLine($"Последняя цифра числа равна " + result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}



