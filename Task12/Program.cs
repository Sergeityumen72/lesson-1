Console.WriteLine("Введите первое число: ");
int num1 = Convert.Toint32(Console.Readline());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.Toint32(Console.Readline());

int remainder = num1 % num2;

if (remainder == 0)
{
    Console.WriteLine("Число" + num1 + "Кратное числу" + num2);
}
else
{
    Console.WriteLine("Число" + num1 + "Кратное числу" + num2 + ". Остаток от деления: " + remainder);
}