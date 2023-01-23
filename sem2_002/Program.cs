// 2. Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int num = new Random().Next(10, 99);
Console.WriteLine("Рандомное число > " + num);
int num1 = num/10;
int num2 = num%10;
if (num1 > num2)
{
    Console.WriteLine("Наибольшая цифра в числе > " + num1);
}
else 
{
    Console.WriteLine("Наибольшая цифра в числе > " + num2);
}
