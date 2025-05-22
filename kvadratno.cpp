#include <iostream>
#include <stdio.h>
#include <math.h>

double poMalukKoren(double a, double b, double c) {
    double desc = b * b - 4 * a * c;

    if (desc < 0) {
        printf_s("Nqma realni koreni.\n");
        return 0;
    }

    double x1 = (-b + sqrt(desc)) / (2 * a);
    printf_s("X1 = %.2lf\n", x1);
    double x2 = (-b - sqrt(desc)) / (2 * a);
    printf_s("X1 = %.2lf\n", x2);

    return (x1 < x2) ? x1 : x2;
}

int main()
{
    double a, b, c;

    printf_s("Vuvedete a, b, c: ");
    scanf_s("%lf %lf %lf", &a, &b, &c);

    if (a == 0) {
        printf_s("Tova ne e kvadratno uravnenie.");
        return 1;
    }

    double koren = poMalukKoren(a, b, c);
    printf_s("Po-malkiqt koren e: %.2lf", koren);
    return 0;



}
