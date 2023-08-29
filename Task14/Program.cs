﻿// 14 Напишите программу которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
// 14 -> Нет
// 26 -> Нет
// 161 -> Да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoDigit(num, 7, 23);
Console.WriteLine(result ? "Да" : "Нет");

bool MultiplicityTwoDigit(int numb, int numb1, int numb2)
{
    return (numb % numb1 == 0 && numb % numb2 == 0);

}