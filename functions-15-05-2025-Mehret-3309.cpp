#include <iostream>
#include <stdio.h>

int Sum(int, int);
int Substract(int, int);
int Multiply(int, int);
int Divide(int, int);


int main()
{
    int a, b, result;

    printf_s("A = ");
    scanf_s("%d", &a);

    printf_s("B = ");
    scanf_s("%d", &b);

    result = Sum(a, b);
    printf_s("A + B = %d\n", result);

    result = Substract(a, b);
    printf_s("A - B = %d\n", result);

    result = Multiply(a, b);
    printf_s("A * B = %d\n", result);

    result = Divide(a, b);
    printf_s("A / B = %d\n", result);

    
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
