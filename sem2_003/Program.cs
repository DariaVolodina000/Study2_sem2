// 3. Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли 
// второе число кратным первому. Если число 2 
// не кратно числу 1, то программа выводит 
// остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int IntputInt(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = IntputInt("Введите делимое число");
int b = IntputInt("Введите делитель");
if (a%b == 0) Console.WriteLine("кратно");
else Console.WriteLine("не кратно, остаток " +a%b );