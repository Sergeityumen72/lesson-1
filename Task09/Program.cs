// int number = new Random().Next(10, 100);  // 99+1
// Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {number}");

// int firstDigit = namber / 10;
// int secondDigit = namber % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = nam / 10;
    int secondDigit = nam % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}