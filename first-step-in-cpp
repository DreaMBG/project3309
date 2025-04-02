
// int = "%d' | float = "%f" | double = "%lf" | char = "%c"

// Да се напише програма, която чете от конзолата число (не непременно цяло) и преобразува
// числото от инчове в сантиметри. За целта умножава инчовете по 2.54 (защото 1 инч = 2.54
// сантиметра).

#include <iostream>
#include <stdio.h>

int main() {
    double inches;
    printf_s("Въведете число (инчове): ");
    scanf_s("%lf", &inches);
    
    double centimeters = inches * 2.54;
    printf_s("%.2f инча са равни на %.2f сантиметра.\n", inches, centimeters);
    
    return 0;
}

// Задача 2 от лева към евро
// Да се напише програма която конвертира въведена от потребителя стойност в лв. и
// отпечатва резултата в евро.

#include <iostream>
#include <stdio.h>

int main()
{
    double lev;
    printf_s("Vuvedete chislo (inch): ");
    scanf_s("%lf", &lev);
    
    double result = lev * 1.96;
    printf_s("%.2f lev/leva sa %.2f euro.\n", lev, result);
    
    return 0;
}

// Задача 3 Периметър
// Да се напише програма, която намира периметъра и лицето на правоъгълник със страни 2,3
// и 3,7.
// - Да се модифицира програмния код и стойностите за страните да се въвеждат от
// потребителя 

#include <iostream>
#include <stdio.h>

int main()
{
    double a, b;
    scanf_s("%lf", &a);
    scanf_s("%lf", &b);
    double resultP = (2 * a) + (2 * b);
    printf_s("P = %.2f\n", resultP);
    
    double resultS = a * b;
    printf_s("S = %.2f \n", resultS);
    
    return 0;
}

// Задача 4 Лица
// Да се напише програма която да пресмята лицата на фигурите:
// - Обем на кълбо
// 𝑣 = (4 ∗ 𝜋 ∗ 𝑟 ^ 3) / 3
// - Лице на Трапец S = (a + b) . h 2 

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    double pi = 3.14;
    double a, b;
    double h;
    double r;

    printf_s("a = ");
    scanf_s("%lf", &a);

    printf_s("b = ");
    scanf_s("%lf", &b);

    printf_s("h = ");
    scanf_s("%lf", &h);

    printf_s("r = ");
    scanf_s("%lf", &r);

    double v = (4.0 * pi * pow(3, r)) / 3;
    printf_s("V = %.2f \n", v);

    double s = ((a + b) * h) / 2;
    printf_s("S = %.2f \n", s);
    
    return 0;
}

// Задача 4 Изчисляване на изрази 

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    double x = 0.5;
    double result = sqrt(pow(2, x) - 6 * x + 9);
    printf_s("Rezultat = %.2f", result);

    double b = 7;
    double result = (sqrt(b) - sqrt(5)) * (sqrt(b) + sqrt(5));
    printf_s("Rezultat = %.2f", result);

    double a, b;
    scanf_s("%lf", &a);
    scanf_s("%lf", &b);
    double result = (sqrt((2 - b) / (a + b) - sqrt(pow(a, 2) - pow(b, 2))));
    printf_s("y = %.2f", result);

    double x, y;
    scanf_s("%lf", &x);
    scanf_s("%lf", &y);
    double result = sqrt((2 * x) / (y + 9)) + sqrt((x - y) / (2 * x));
    printf_s("y = %.2f", result);

    double x, k;
    scanf_s("%lf", &x);
    scanf_s("%lf", &k);
    double result = ((x - k) / (4 * x * k)) + 1 / (2 * k);
    printf_s("y = %.2f", result);

    double a, b;
    scanf_s("%lf", &a);
    scanf_s("%lf", &b);
    double result = (a / (pow(a, 2) + pow(b, 2))) + (b / (2 * a));
    printf_s("y = %.2f", result);
    
    return 0;
}

// Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и
// котки. Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50
// лв, а опаковка храна за котки струва 4 лв. 

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    int dog_food, cat_food;

    const double dog_price = 2.50;
    const double cat_price = 4.00;

    printf_s("Vuvedete broq opakovki za kucheta: ");
    scanf_s("%d", &dog_food);
    
    printf_s("Vuvedete broq opakovki za kotki: ");
    scanf_s("%d", &cat_food);

    double total = (dog_food * dog_price) + (cat_food * cat_price);
    printf_s("Obshto: %.2f lv.\n", total);
    
    return 0;
}

// Задача 6 конзолен конвертор - от градуси °C към градуси °F
// Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува
// до градуси по скалата на Фаренхайт (°F). Потърсете в Интернет подходяща формула, с
// която да извършите изчисленията. Закръглете резултата до 2 символа след десетичния
// знак.

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    double celsius;
    printf_s("Temperatura v Celsius: ");
    scanf_s("%lf", &celsius);

    double fahrenheit = (celsius * 9.0 / 5.0) + 32;
    printf_s("%.2f gradusa Celsius sa %.2f gradusa fahrenheit.\n", celsius, fahrenheit);
    
    return 0;
}


// =================== FINAL =================
