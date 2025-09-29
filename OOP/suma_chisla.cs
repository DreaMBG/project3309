int number;
int sum = 0;

Console.WriteLine("Въвеждайте полочителни числа. Въвеждането на 0 ще прекрати програмата.");

do
{
    Console.Write("Въведете число: ");
    number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        sum += number;
    }
    else if (number < 0)
    {
        Console.WriteLine("Моля, въведете само положителни числа!");
    }
} while (number != 0);

Console.WriteLine($"Сумата на въведените числа е: {sum}");
