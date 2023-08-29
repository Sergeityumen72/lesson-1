Console.WriteLine("Введите 1ое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ое число");
int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 / num2 == num2)
// {
//     Console.WriteLine("Верно");
// }
// else
// {
//     Console.WriteLine("Не верно");
// }
bool result = MultTwoNum(num1, num2);
Console.WriteLine(result ? "Да" : "Нет");

bool MultTwoNum(int numb1, int numb2)
{
    return numb1 / numb2 == numb2 || numb2 / numb1 == numb1;
}
