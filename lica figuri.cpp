#include <iostream>
#include <stdio.h>
#include <math.h>

double LiceKrug(double);
double LicePravougulnik(double, double);
double LiceTriugulnik(double, double);

int main()
{
    int choice;
    double a, b, result;

    printf_s("Calculator Za Lica\n");
    printf_s("1. Lice na krug\n");
    printf_s("2. Lice na pravougulnik\n");
    printf_s("3. Lice na triugulnik\n");
    printf_s("Napravete izbor (1-3): ");
    scanf_s("%d", &choice);

    switch (choice) {
        case 1:
            double r;
            printf_s("R = ");
            scanf_s("%lf", &r);
            result = LiceKrug(r);
            printf_s("S = %.2lf", result);
            break;
        case 2:
            printf_s("A = ");
            scanf_s("%lf", &a);
            printf_s("B = ");
            scanf_s("%lf", &b);

            result = LicePravougulnik(a, b);
            printf_s("S = %.2lf", result);
            break;
        case 3:
            double ha;
            printf_s("A = ");
            scanf_s("%lf", &a);
            printf_s("Ha = ");
            scanf_s("%lf", &ha);
            result = LiceTriugulnik(a, ha);
            printf_s("S = %.2lf", result);
            break;
        default:
            printf_s("Nevaliden izbor!");
    }
    return 0;
}

double LiceKrug(double r) {
    double pi = 3.14;
    double result = pi * pow(r, 2);
    return result;
}

double LicePravougulnik(double a, double b) {
    double result = a * b;
    return result;
}

double LiceTriugulnik(double a, double ha) {
    double result = (a * ha) / 2;
    return result;
}



