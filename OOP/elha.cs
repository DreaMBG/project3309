Console.Write("Въведете височина на елхата (напр. 8) или натиснете ENTER за стойност по подразбиране: ");
string input = Console.ReadLine();
int height;

if (!int.TryParse(input, out height) || height < 1)
{
    height = 8; // стойност по подразбиране ако няма зададена стойност
}

// започва изработването на елхата без долната част
for (int row = 0; row < height; row++)
{
    int spaces = height - row - 1;
    int stars = 2 * row + 1;

    Console.Write(new string(' ', spaces));
    Console.WriteLine(new string('*', stars));
}

int trunkWidth = Math.Max(1, height / 3); // ширина на долната част
if (trunkWidth % 2 == 0) trunkWidth++; // центрираме долната част
int trunkHeight = Math.Max(1, height / 4); // височина на долната част 
int trunkPadding = (2 * height + 1 - trunkWidth) / 2; 

for (int t = 0; t < trunkHeight; t++)
{
    Console.Write(new string(' ', trunkPadding));
    Console.WriteLine(new string('|', trunkWidth));
}
