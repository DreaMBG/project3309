#include <iostream>
#include <stdio.h>

int Sum(int, int);
int Substract(int, int);
int Multiply(int, int);
int Divide(int, int);

int main()
{
    int choice;
    int a, b, result;
    
    printf_s("Calculator C++\n");
    printf_s("1. Subirane\n");
    printf_s("2. Izvajdane\n");
    printf_s("3. Umnojenie\n");
    printf_s("4. Delenie\n");
    printf_s("Napravete opciq (1-4): ");
    scanf_s("%d", &choice);

    printf_s("Vuvedete purvoto chislo: ");
    scanf_s("%d", &a);

    printf_s("Vuvedete vtoroto chislo: ");
    scanf_s("%d", &b);

    switch (choice) {
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
            printf_s("Nevaliden izbor!");
            break;
    }
    return 0;

}

int Sum(int x, int y) {
    int z = x + y;
    return z;
}

int Substract(int x, int y) {
    int z = x - y;
    return z;
}

int Multiply(int x, int y) {
    int z = x * y;
    return z;
}

int Divide(int x, int y) {
    if (y != 0) {
        int z = x / y;
        return z;
    }
}





