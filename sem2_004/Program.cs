// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("проверим число на кратно 7 и 23 одновременно. Введите число > ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%7 == 0 & num%23==0) Console.WriteLine("yes");
else Console.WriteLine("no");