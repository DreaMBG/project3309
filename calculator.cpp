//Калкулатор на C++, като се използва Switch case и потребителят може сам да избере опция (1-4). Различните операции са разделени с функции.
#include <iostream>
#include <stdio.h>
#include <math.h>

int Sum(int, int);
int Substract(int, int);
int Multiply(int, int);
int Divide(int, int);

int main()
{
    int a, b, count, result;
    
    printf_s("Calculator CPP\n");
    printf_s("1. Subirane\n");
    printf_s("2. Izvajdane\n");
    printf_s("3. Umnojenie\n");
    printf_s("4. Delenie\n");
    printf_s("Napravete izbor (1-4): ");
    scanf_s("%d", &count);


    printf_s("A = ");
    scanf_s("%d", &a);
    printf_s("B = ");
    scanf_s("%d", &b);

    switch (count) {
        case 1:
            result = Sum(a, b);
            printf_s("A + B = %d", result);
            break;
        case 2:
            result = Substract(a, b);
            printf_s("A - B = %d", result);
            break;
        case 3:
            result = Multiply(a, b);
            printf_s("A * B = %d", result);
            break;
        case 4:
            result = Divide(a, b);
            printf_s("A / B = %d", result);
            break;
        default:
            printf_s("Nevalidna opciq.");
            break;

    }

    return 0;
}

int Sum(int x, int y) {
    int z;
    z = x + y;
    return z;
}

int Substract(int x, int y) {
    int z;
    z = x - y;
    return z;
}

int Multiply(int x, int y) {
    int z;
    z = x * y;
    return z;
}

int Divide(int x, int y) {
    if (y != 0) {
        int z;
        z = x / y;
        return z;
    }

    return 0;
}

