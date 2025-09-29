Console.Write("Въведете число n: ");
int n = int.Parse(Console.ReadLine());
long factorial = 1;

for (int i = 1;  i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine($"{n}! = {factorial}");
