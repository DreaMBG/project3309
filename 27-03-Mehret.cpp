// 27-03-Mehret.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
#include <math.h>

int main()
{
    /*double a;
    scanf_s("%lf", &a);

    double b;
    scanf_s("%lf", &b);

    if (a > b) {
        printf_s("%lf", a);
    }
    else {
        printf_s("%lf", b);
    }*/

    double a, b, c;

    scanf_s("%lf", &a);
    scanf_s("%lf", &b);
    scanf_s("%lf", &c);

    if ((fabs(a - b) < c) && (c < a + b)) {
        printf_s("Validen triagalnik \n");
    }
    else {
        printf_s("Nevaliden triagalnik");
    }


    if (a == b && b == c) {
        printf_s("Ravnostranen");
    }
    else if (a == b || a == c || b == c) {
        printf_s("Ravnobedren");
    }
    else {
        printf_s("Raznostranen");
    }

    /*float a, b, c;
    scanf_s("%f", &a);
    scanf_s("%f", &b);
    scanf_s("%f", &c);

    if (a != 0) {
        double D = b * b - 4 * a * c;
        if (D < 0) {
            printf_s("Nqma realni koreni");
        }
        else {
            if (D == 0) {
                double x;
                x = -b / (2 * a);
                printf_s("%lf", x);
            }
            else {
                double x1, x2;
                x1 = (-b + sqrt(D)) / (2 * a);
                x2 = (-b - sqrt(D)) / (2 * a);
                printf_s("X1 = %lf , X2 = %lf", x1, x2);
            }
        }
    }*/



}

