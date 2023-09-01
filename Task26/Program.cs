//  Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int Quantity(int num)
{
    int count = 0;
    while (num>0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = Quantity(number);
if (number < 0);
Console.WriteLine($"В числе{number} -> {quantity} знака");